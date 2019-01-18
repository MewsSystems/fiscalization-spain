using System;
using System.IO;
using System.Linq;
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

            var model = GetSampleInvoiceData();
            var response = await client.SendRevenueAsync(model);
            Console.WriteLine(response.Result.ToString());
            Assert.Equal(RegisterResult.Correct, response.Result);
        }

        private InvoicesToRegister GetSampleInvoiceData()
        {
            var issuingCompany = Credentials.GeneratorCompany;
            var payingCompany = Credentials.MicrosoftCompany;
            var firstInvoiceNumber = 18;

            return new InvoicesToRegister(
                new Header(issuingCompany, CommunicationType.Registration),
                new[]
                {
                    GetInvoice(firstInvoiceNumber++, issuingCompany, payingCompany),
                    GetInvoice(firstInvoiceNumber++, issuingCompany, payingCompany),
                    GetInvoice(firstInvoiceNumber++, issuingCompany, payingCompany)
                }
            );
        }

        private Invoice GetInvoice(int invoiceNumber, LocalCompany issuingCompany, LocalCompany payingCompany)
        {
            var breakdowns = GetBreakdowns();
            var totalValue = Math.Round(breakdowns.Sum(b => b.TaxAmount.Value + b.TaxBaseAmount.Value), 2);

            return new Invoice(
                new TaxPeriod(new Year(2017), Month.December),
                new InvoiceId(issuingCompany.TaxPayerNumber, new LimitedString1to60(invoiceNumber.ToString("D2")), new DateTime(2017, 5, 10)),
                InvoiceType.Invoice,
                SchemeOrEffect.GeneralTaxRegimeActivity,
                new Amount(totalValue),
                new LimitedString500("This is a test invoice."),
                new CounterPartyCompany(payingCompany),
                new BreakdownItem(new InvoiceItem(new WithTaxItem(TransactionType.NotExempt, breakdowns)))
            );
        }

        private VATBreakdown[] GetBreakdowns()
        {
            return new[]
            {
                GetBreakdown(21m, 22.07M),
                GetBreakdown(21m, 32.07M),
                GetBreakdown(21m, 42.07M),
                GetBreakdown(21m, 52.07M)
            };
        }

        private VATBreakdown GetBreakdown(decimal vat, decimal baseValue)
        {
            return new VATBreakdown(new Percentage(vat), new Amount(baseValue), new Amount( Math.Round(baseValue * vat / 100, 2)));
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
