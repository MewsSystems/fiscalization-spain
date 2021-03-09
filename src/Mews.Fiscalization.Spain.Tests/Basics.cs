using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FuncSharp;
using Mews.Fiscalization.Core.Model;
using Mews.Fiscalization.Spain.Model;
using Mews.Fiscalization.Spain.Model.Request;
using Mews.Fiscalization.Spain.Nif;
using NUnit.Framework;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        public static readonly X509Certificate2 Certificate = new X509Certificate2(
            rawData: Convert.FromBase64String(System.Environment.GetEnvironmentVariable("certificate_data") ?? "INSERT_CERTIFICATE_DATA"),
            password: System.Environment.GetEnvironmentVariable("certificate_password") ?? "INSERT_CERTIFICATE_PASSWORD",
            keyStorageFlags: X509KeyStorageFlags.DefaultKeySet
        );
        public static readonly Client Client = new Client(Certificate, Environment.Test, httpTimeout: TimeSpan.FromSeconds(30));

        public static readonly LocalCompany IssuingCompany = new LocalCompany(
            name: new LimitedString120(System.Environment.GetEnvironmentVariable("issuer_name") ?? "INSERT_ISSUER_NAME"),
            taxpayerIdentificationNumber: TaxpayerIdentificationNumber.Create(Countries.Spain, System.Environment.GetEnvironmentVariable("issuer_tax_number") ?? "INSERT_ISSUER_TAX_NUMBER").Success.Get()
        );

        public static readonly LocalCompany ReceivingCompany = new LocalCompany(
            name: new LimitedString120(System.Environment.GetEnvironmentVariable("receiver_name") ?? "INSERT_RECEIVER_NAME"),
            taxpayerIdentificationNumber: TaxpayerIdentificationNumber.Create(Countries.Spain, System.Environment.GetEnvironmentVariable("receiver_tax_number") ?? "INSERT_RECEIVER_TAX_NUMBER").Success.Get()
        );

        [Test]
        public async Task CheckNif()
        {
            var goodEntries = NonEmptyEnumerable.Create(
                new NifInfoEntry(IssuingCompany.TaxpayerIdentificationNumber, IssuingCompany.Name.Value),
                new NifInfoEntry(ReceivingCompany.TaxpayerIdentificationNumber, ReceivingCompany.Name.Value),
                new NifInfoEntry(TaxpayerIdentificationNumber.Create(Countries.Spain, "99999999R").Success.Get(), "ESPAÑOL ESPAÑOL JUAN"),
                new NifInfoEntry(IssuingCompany.TaxpayerIdentificationNumber, "Wrong company name") // surprisingly, good company ID with bad company name is found
            );
            var badEntries = NonEmptyEnumerable.Create(
                new NifInfoEntry(TaxpayerIdentificationNumber.Create(Countries.Spain, "111111111").Success.Get(), IssuingCompany.Name.Value),
                new NifInfoEntry(TaxpayerIdentificationNumber.Create(Countries.Spain, "99999999R").Success.Get(), "Not Juan"),
                new NifInfoEntry(TaxpayerIdentificationNumber.Create(Countries.Spain, "12999999R").Success.Get(), "Non existent name for non existent ID.")
            );

            await AssertNifLookup(goodEntries, NifSearchResult.Found);
            await AssertNifLookup(badEntries, NifSearchResult.NotFound);

            // Surprisingly, this works for some reason.
            var serverModifiedEntry = new NifInfoEntry(TaxpayerIdentificationNumber.Create(Countries.Spain, "A08433179").Success.Get(), "Microsoft test company");
            await AssertNifLookup(serverModifiedEntry.ToEnumerable(), NifSearchResult.NotFoundBecauseNifModifiedByServer);
        }

        [Test]
        [TestCase(1, false, true, true)]
        [TestCase(2, false, true, false)]
        [TestCase(3, false, false, true)]

        [TestCase(4, true, true, true)]
        [TestCase(5, true, true, false)]
        [TestCase(6, true, false, true)]

        [TestCase(7, false, false, false, false)]
        [TestCase(8, true, false, false, false)]
        public async Task SendInvoics(int invoiceIndex, bool isOperationTypeTaxBreakdown, bool addTaxExemptItems, bool addTaxedItems, bool expectedSuccess = true)
        {
            var invoice = GetInvoice(IssuingCompany, ReceivingCompany, isOperationTypeTaxBreakdown, addTaxExemptItems, addTaxedItems, invoiceIndex);
            await invoice.Match(
                async i =>
                {
                    if (!expectedSuccess)
                    {
                        Assert.Fail("Expected to fail but was success.");
                    }
                    else
                    {
                        var model = new InvoicesToSubmit(
                            header: new Header(IssuingCompany, CommunicationType.Registration),
                            addedInvoices: new[] { i }
                        );

                        var response = await Client.SubmitInvoiceAsync(model).ConfigureAwait(continueOnCapturedContext: false);

                        var responseErrorMessages = response.Invoices.Select(result => result.ErrorMessage).Flatten();
                        var errorMessage = String.Join(System.Environment.NewLine, responseErrorMessages);
                        Assert.AreEqual(RegisterResult.Correct, response.Result, errorMessage);
                    }
                },
                async _ =>
                {
                    await Task.Run(() =>
                    {
                        if (expectedSuccess)
                        {
                            Assert.Fail("Expected to success but failed", invoice.Error.Get().Select(e => e.Message).MkString(", "));
                        }

                        Assert.Pass();
                    });
                }
            );
        }

        /// <summary>
        /// This test does work. However the method is private as we probably haven't really verified its functionality, so the test will stay commented for now.
        /// </summary>
        // [Fact]
        // public async Task DeleteInvoice()
        // {
        //     var sentInvoice = await SuccessfullyPostInvoice(Client);
        //
        //     var model = new InvoicesToDelete(
        //         header: new Header(IssuingCompany, CommunicationType.Registration),
        //         invoices: new [] { sentInvoice }
        //     );
        //     var response = await Client.RemoveInvoiceAsync(model);
        //     Assert.NotNull(response);
        // }

        private async Task AssertNifLookup(INonEmptyEnumerable<NifInfoEntry> entries, NifSearchResult expectedResult)
        {
            var validator = new NifValidator(Certificate, httpTimeout: TimeSpan.FromSeconds(30));
            var response = await validator.CheckNif(new Request(entries));

            Assert.AreEqual(response.Results.Count(), entries.Count());
            foreach (var result in response.Results)
            {
                Assert.AreEqual(expectedResult, result.Result);
            }
        }

        private ITry<AddedInvoice, IEnumerable<Error>> GetInvoice(
            LocalCompany issuingCompany,
            LocalCompany payingCompany,
            bool isOperationTypeTaxBreakdown,
            bool addTaxExemptItems,
            bool addTaxedItems,
            int invoiceIndex = 1)
        {
            var taxRateSummaries = addTaxedItems.Match(
                t => new[] { GetTaxRateSummary(21m, 42.07M) },
                f => null
            );
            var taxExemptItems = addTaxExemptItems.Match(
                t => new[] { new TaxExemptItem(new Amount(20m), CauseOfExemption.OtherGrounds) },
                f => null
            );

            var taxSummary = TaxSummary.Create(taxExemptItems, taxRateSummaries);
            var breakdown = isOperationTypeTaxBreakdown.Match(
                t => taxSummary.FlatMap(s => OperationTypeTaxBreakdown.Create(s, s).Map(b => new TaxBreakdown(b))),
                f => taxSummary.Map(s => new TaxBreakdown(s))
            );

            var nowUtc = DateTime.UtcNow;
            var issueDateUtc = nowUtc.Date;
            var invoiceNumber = $"Bill-{nowUtc:yyyy-MM-dd-HH-mm-ss}-{invoiceIndex}";

            return breakdown.Map(b => new AddedInvoice(
                taxPeriod: new TaxPeriod(new Year(issueDateUtc.Year), (Month)(issueDateUtc.Month - 1)),
                id: new InvoiceId(issuingCompany.TaxpayerIdentificationNumber, new LimitedString1to60(invoiceNumber), issueDateUtc),
                type: InvoiceType.Invoice,
                schemeOrEffect: SchemeOrEffect.GeneralTaxRegimeActivity,
                description: new LimitedString500("This is a test invoice."),
                taxBreakdown: b,
                counterParty: new CounterPartyCompany(payingCompany),
                issuedByThirdParty: true
            ));
        }

        private TaxRateSummary GetTaxRateSummary(decimal vat, decimal baseValue)
        {
            return new TaxRateSummary(new Percentage(vat), new Amount(baseValue), new Amount(Math.Round(baseValue * vat / 100, 2)));
        }
    }
}
