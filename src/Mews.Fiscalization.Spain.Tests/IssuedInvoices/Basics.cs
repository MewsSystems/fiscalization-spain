using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Model;
using Mews.Fiscalization.Spain.Nif;
using Mews.Fiscalization.Spain.Tests.Configuration;
using NUnit.Framework;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        public static readonly string CertificateData = System.Environment.GetEnvironmentVariable("certificate_data") ?? "INSERT_CERTIFICATE_DATA";
        public static readonly string CertificatePassword = System.Environment.GetEnvironmentVariable("certificate_password") ?? "INSERT_CERTIFICATE_PASSWORD";

        [Test]
        public async Task CheckNif()
        {
            var certificate = GeneratorCertificate();
            var validator = new NifValidator(certificate, TimeSpan.FromSeconds(30));

            var entries = new List<NifInfoEntry>
            {
                new NifInfoEntry(Credentials.TestCompany1.TaxPayerNumber.Number, Credentials.TestCompany1.Name.Value),
                new NifInfoEntry(Credentials.TestCompany2.TaxPayerNumber.Number, Credentials.TestCompany2.Name.Value),
                new NifInfoEntry("99999999R", "Juan Espanol Espanol"),
                new NifInfoEntry("12999999R", "Test name")
            };
            
            var response = await validator.CheckNif(new Request(entries));
            Assert.IsNotNull(response);
        }

        [Test]
        public async Task PostInvoice()
        {
            var certificate = GeneratorCertificate();
            var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));

            var model = GetInvoicesToSubmit(firstInvoiceNumber: 666, invoiceCount: 1);
            var response = await client.SubmitInvoiceAsync(model).ConfigureAwait(continueOnCapturedContext: false);
            Console.WriteLine(response.Result.ToString());
            Assert.AreEqual(RegisterResult.Correct, response.Result);
        }

        //[Test]
        //public async Task DeleteInvoice()
        //{
        //    var certificate = GeneratorCertificate();
        //    var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));

        //    var model = GetInvoicesToRemove(firstInvoiceNumber: 09, invoiceCount: 1);
        //    var response = await client.RemoveInvoiceAsync(model);
        //    Assert.NotNull(response);
        //}

        //private InvoicesToDelete GetInvoicesToRemove(int firstInvoiceNumber, int invoiceCount)
        //{
        //    var issuingCompany = Credentials.TestCompany1;
        //    var payingCompany = Credentials.TestCompany2;
        //    var invoices = Enumerable.Range(firstInvoiceNumber, invoiceCount).Select(i =>
        //        GetInvoice(i, issuingCompany, payingCompany)
        //    );
        //
        //    return new InvoicesToDelete(
        //        header: new Header(issuingCompany, CommunicationType.Registration),
        //        invoices: invoices.ToArray()
        //    );
        //}

        private InvoicesToSubmit GetInvoicesToSubmit(int firstInvoiceNumber, int invoiceCount)
        {
            var issuingCompany = Credentials.TestCompany1;
            var payingCompany = Credentials.TestCompany2;
            var invoices = Enumerable.Range(firstInvoiceNumber, invoiceCount).Select(i =>
                GetInvoice(i, issuingCompany, payingCompany)
            );

            return new InvoicesToSubmit(
                header: new Header(issuingCompany, CommunicationType.Registration),
                addedInvoices: invoices.ToArray()
            );
        }

        private AddedInvoice GetInvoice(int invoiceNumber, LocalCompany issuingCompany, LocalCompany payingCompany)
        {
            var breakdowns = GetBreakdowns();
            var totalValue = Math.Round(breakdowns.Sum(b => b.TaxAmount.Value + b.TaxBaseAmount.Value), 2);

            return new AddedInvoice(
                new TaxPeriod(new Year(2017), Month.December),
                new InvoiceId(issuingCompany.TaxPayerNumber, new LimitedString1to60(invoiceNumber.ToString("D2")), new DateTime(2017, 5, 10)),
                InvoiceType.SimplifiedInvoice,
                SchemeOrEffect.GeneralTaxRegimeActivity,
                new Amount(totalValue),
                new LimitedString500("This is a test invoice."),
                new BreakdownItem(new InvoiceItem(
                    withTax: new WithTaxItem(TransactionType.NotExempt, breakdowns),
                    taxFree: GetTaxFreeItems()
                )),
                new CounterPartyCompany(payingCompany)
            );
        }

        private TaxFreeItem[] GetTaxFreeItems()
        {
            return new TaxFreeItem[]
            {
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds),
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds),
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds),
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds),
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds),
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds),
                new TaxFreeItem(new Amount(20m), CauseOfExemption.OtherGrounds)
            };
        }

        private VATBreakdown[] GetBreakdowns()
        {
            return new[]
            {
                GetBreakdown(21m, -42.07M),
                GetBreakdown(21m, -52.07M),
                GetBreakdown(21m, -52.07M),
                GetBreakdown(21m, -52.07M),
                GetBreakdown(21m, -52.07M),
                GetBreakdown(21m, -52.07M)
            };
        }

        private VATBreakdown GetBreakdown(decimal vat, decimal baseValue)
        {
            return new VATBreakdown(new Percentage(vat), new Amount(baseValue), new Amount(Math.Round(baseValue * vat / 100, 2)));
        }

        private X509Certificate2 GeneratorCertificate()
        {
            return new X509Certificate2(rawData: Convert.FromBase64String(CertificateData), password: CertificatePassword, keyStorageFlags: X509KeyStorageFlags.DefaultKeySet);
        }
    }
}
