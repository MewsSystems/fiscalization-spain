using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Model;
using Mews.Fiscalization.Spain.Nif;
using Mews.Fiscalization.Spain.Tests.Configuration;
using Xunit;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        [Fact]
        public async Task CheckNif()
        {
            var validator = new NifValidator(TimeSpan.FromSeconds(30));

            var entries = new List<NifInfoEntry>
            {
                new NifInfoEntry(Credentials.GeneratorCompany.TaxPayerNumber.Number, Credentials.GeneratorCompany.Name.Value),
                new NifInfoEntry(Credentials.MicrosoftCompany.TaxPayerNumber.Number, Credentials.MicrosoftCompany.Name.Value),
                new NifInfoEntry("99999999R", "ESPAÑOL ESPAÑOL JUAN")
            };
            
            var response = await validator.CheckNif(new Request(entries));
            Assert.NotNull(response);
        }

        //[Fact]
        //public async Task DeleteInvoice()
        //{
        //    var certificate = GeneratorCertificate();
        //    var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));

        //    var model = GetInvoicesToRemove(firstInvoiceNumber: 09, invoiceCount: 1);
        //    var response = await client.RemoveInvoiceAsync(model);
        //    Assert.NotNull(response);
        //}

        [Fact]
        public async Task PostInvoice()
        {
            var certificate = GeneratorCertificate();
            var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));

            var model = GetInvoicesToSubmit(firstInvoiceNumber: 09, invoiceCount: 1);
            var response = await client.SubmitInvoiceAsync(model);
            Console.WriteLine(response.Result.ToString());
            Assert.Equal(RegisterResult.Correct, response.Result);
        }

        private InvoicesToDelete GetInvoicesToRemove(int firstInvoiceNumber, int invoiceCount)
        {
            var issuingCompany = Credentials.GeneratorCompany;
            var payingCompany = Credentials.MicrosoftCompany;
            var invoices = Enumerable.Range(firstInvoiceNumber, invoiceCount).Select(i =>
                GetInvoice(i, issuingCompany, payingCompany)
            );

            return new InvoicesToDelete(
                header: new Header(issuingCompany, CommunicationType.Registration),
                invoices: invoices.ToArray()
            );
        }

        private InvoicesToSubmit GetInvoicesToSubmit(int firstInvoiceNumber, int invoiceCount)
        {
            var issuingCompany = Credentials.GeneratorCompany;
            var payingCompany = Credentials.MicrosoftCompany;
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
                    taxFree: new TaxFreeItem[] {}
                )),
                new CounterPartyCompany(payingCompany)
            );
        }

        private VATBreakdown[] GetBreakdowns()
        {
            return new[]
            {
                GetBreakdown(21m, -22.07M),
                GetBreakdown(21m, -32.07M),
                GetBreakdown(21m, -42.07M),
                GetBreakdown(21m, -52.07M)
            };
        }

        private VATBreakdown GetBreakdown(decimal vat, decimal baseValue)
        {
            return new VATBreakdown(new Percentage(vat), new Amount(baseValue), new Amount(Math.Round(baseValue * vat / 100, 2)));
        }

        private X509Certificate GeneratorCertificate()
        {
            string password = File.ReadAllText("C:\\Users\\PavelKalandra\\Documents\\SII\\GenBCN1 2017.iso", Encoding.UTF8);
            X509Certificate cert = new X509Certificate();
            cert.Import("C:\\Users\\PavelKalandra\\Documents\\SII\\GenBCN1 2017.pfx", password, X509KeyStorageFlags.UserKeySet);
            return cert;
        }
    }
}
