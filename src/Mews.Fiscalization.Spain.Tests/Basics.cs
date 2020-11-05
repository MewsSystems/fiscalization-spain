using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FuncSharp;
using Mews.Fiscalization.Spain.Model;
using Mews.Fiscalization.Spain.Nif;
using NUnit.Framework;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        public static readonly string CertificateData = System.Environment.GetEnvironmentVariable("certificate_data") ?? "INSERT_CERTIFICATE_DATA";
        public static readonly string CertificatePassword = System.Environment.GetEnvironmentVariable("certificate_password") ?? "INSERT_CERTIFICATE_PASSWORD";
        public static readonly LocalCompany IssuingCompany = new LocalCompany(
            new LimitedString120(System.Environment.GetEnvironmentVariable("issuer_name") ?? "INSERT_ISSUER_NAME"),
            new TaxPayerNumber(System.Environment.GetEnvironmentVariable("issuer_tax_number") ?? "INSERT_ISSUER_TAX_NUMBER")
        );

        public static readonly LocalCompany ReceivingCompany = new LocalCompany(
            new LimitedString120(System.Environment.GetEnvironmentVariable("receiver_name") ?? "INSERT_RECEIVER_NAME"),
            new TaxPayerNumber(System.Environment.GetEnvironmentVariable("receiver_tax_number") ?? "INSERT_RECEIVER_TAX_NUMBER")
        );

        [Test]
        public async Task CheckNif()
        {
            var goodEntries = new List<NifInfoEntry>
            {
                new NifInfoEntry(IssuingCompany.TaxPayerNumber.Number, IssuingCompany.Name.Value),
                new NifInfoEntry(ReceivingCompany.TaxPayerNumber.Number, ReceivingCompany.Name.Value),
                new NifInfoEntry("99999999R", "ESPAÑOL ESPAÑOL JUAN"),
                new NifInfoEntry(IssuingCompany.TaxPayerNumber.Number, "Wrong company name"), // surprisingly, good company ID with bad company name is found
            };
            var badEntries = new List<NifInfoEntry>
            {
                new NifInfoEntry("NotTheId", IssuingCompany.Name.Value),
                new NifInfoEntry("99999999R", "Not Juan"),
                new NifInfoEntry("12999999R", "Non existent name for non existent ID."),
            };

            await AssertNifLookup(goodEntries, NifSearchResult.Found);
            await AssertNifLookup(badEntries, NifSearchResult.NotFound);
        }

        [Test]
        public async Task PostInvoice()
        {
            var certificate = GeneratorCertificate();
            var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));
            await SuccessfullyPostInvoice(client);
        }

        /// <summary>
        /// This test does work. However the method is private as we probably haven't really verified its functionality, so the test will stay commented for now.
        /// </summary>
        // [Fact]
        // public async Task DeleteInvoice()
        // {
        //     var certificate = GeneratorCertificate();
        //     var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));
        //     var sentInvoice = await SuccessfullyPostInvoice(client);
        //
        //     var model = new InvoicesToDelete(
        //         header: new Header(IssuingCompany, CommunicationType.Registration),
        //         invoices: new [] { sentInvoice }
        //     );
        //     var response = await client.RemoveInvoiceAsync(model);
        //     Assert.NotNull(response);
        // }

        private async Task<AddedInvoice> SuccessfullyPostInvoice(Client client)
        {
            var invoice = GetInvoice(IssuingCompany, ReceivingCompany);
            var model = new InvoicesToSubmit(
                header: new Header(IssuingCompany, CommunicationType.Registration),
                addedInvoices:  new [] { invoice }
            );

            var response = await client.SubmitInvoiceAsync(model).ConfigureAwait(continueOnCapturedContext: false);

            var responseErrorMessages = response.Invoices.Select(i => i.ErrorMessage).Flatten();
            var errorMessage = String.Join(System.Environment.NewLine, responseErrorMessages);
            Assert.AreEqual(response.Result, RegisterResult.Correct, errorMessage);

            return invoice;
        }

        private async Task AssertNifLookup(List<NifInfoEntry> entries, NifSearchResult expectedResult)
        {
            var certificate = GeneratorCertificate();
            var validator = new NifValidator(certificate, httpTimeout: TimeSpan.FromSeconds(30));

            var response = await validator.CheckNif(new Request(entries));
            Assert.AreEqual(response.Results.Count(), entries.Count);
            foreach (var result in response.Results)
            {
                Assert.AreEqual(result.Result, expectedResult);
            }
        }

        private AddedInvoice GetInvoice(LocalCompany issuingCompany, LocalCompany payingCompany, int invoiceIndex = 1)
        {
            var taxBreakdowns = new[] { GetBreakdown(21m, 42.07M) };
            var taxFreeItems = new[] { new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds) };
            var totalTaxedValue = taxBreakdowns.Sum(b => b.TaxAmount.Value + b.TaxBaseAmount.Value);
            var totalUntaxedValue = taxFreeItems.Sum(i => i.Amount.Value);
            var totalAmount = new Amount(Math.Round(totalTaxedValue + totalUntaxedValue, 2));

            var nowUtc = DateTime.UtcNow;
            var issueDateUtc = nowUtc.Date;
            var invoiceNumber = $"Bill-{nowUtc:yyyy-MM-dd-HH-mm-ss}-{invoiceIndex}";

            return new AddedInvoice(
                new TaxPeriod(new Year(issueDateUtc.Year), (Month)(issueDateUtc.Month - 1)),
                new InvoiceId(issuingCompany.TaxPayerNumber, new LimitedString1to60(invoiceNumber), issueDateUtc),
                InvoiceType.Invoice,
                SchemeOrEffect.GeneralTaxRegimeActivity,
                totalAmount,
                new LimitedString500("This is a test invoice."),
                new BreakdownItem(new InvoiceItem(
                    withTax: new WithTaxItem(TransactionType.NotExempt, taxBreakdowns),
                    taxFree: taxFreeItems
                )),
                new CounterPartyCompany(payingCompany)
            );
        }

        private VATBreakdown GetBreakdown(decimal vat, decimal baseValue)
        {
            return new VATBreakdown(new Percentage(vat), new Amount(baseValue), new Amount(Math.Round(baseValue * vat / 100, 2)));
        }

        private static X509Certificate2 GeneratorCertificate()
        {
            return new X509Certificate2(rawData: Convert.FromBase64String(CertificateData), password: CertificatePassword, keyStorageFlags: X509KeyStorageFlags.DefaultKeySet);
        }
    }
}
