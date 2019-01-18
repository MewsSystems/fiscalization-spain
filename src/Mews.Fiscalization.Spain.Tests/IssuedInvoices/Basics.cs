using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Model;
using Mews.Fiscalization.Spain.Tests.Configuration;
using Xunit;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        [Fact]
        public async Task SendRevenueSimple()
        {
            var certificate = GeneratorCertificate();
            var client = new Client(certificate, Environment.Test, TimeSpan.FromSeconds(30));

            var model = GetSampleInvoiceData(13);
            var response = await client.SendRevenueAsync(model);
            Assert.NotNull(response);
        }

        private InvoicesToRegister GetSampleInvoiceData(int invoiceNumber)
        {
            var issuingCompany = Credentials.GeneratorCompany;
            var payingCompany = Credentials.MicrosoftCompany;

            var invoice = new Invoice(
                taxPeriod: new TaxPeriod(new Year(2017), Month.December),
                id: new InvoiceId(issuingCompany.TaxPayerNumber, new LimitedString1to60(invoiceNumber.ToString("D2")), new DateTime(2017, 5, 10)),
                type: InvoiceType.Invoice,
                schemeOrEffect: SchemeOrEffect.GeneralTaxRegimeActivity,
                totalAmount: new Amount(26.7M),
                description: new LimitedString500("This is a test invoice."),
                counterParty: new CounterPartyCompany(payingCompany),
                breakdown: new BreakdownItem(new InvoiceItem(new WithTaxItem(TransactionType.NotExempt, new[]
                {
                    new VATBreakdown(new Percentage(21), new Amount(22.07M), new Amount(4.63M))
                })))
            );
            return new InvoicesToRegister(
                new Header(issuingCompany, CommunicationType.Registration),
                new[] { invoice }
            );
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
