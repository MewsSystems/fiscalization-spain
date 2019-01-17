using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Communication;
using Mews.Fiscalization.Spain.Environment;
using Mews.Fiscalization.Spain.Model;
using Xunit;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        [Fact]
        public async Task SendRevenueSimple()
        {
            var certificate = GeneratorCertificate();
            var client = new SiiSoapClient(certificate, SiiEnvironment.Test, TimeSpan.FromSeconds(30));
            var model = GetSampleInvoiceData(11);
            var dtoModel = new ModelToDtoConverter().Convert(model);

            var response = await client.SendRevenueAsync(dtoModel);
            Assert.NotNull(response);
        }

        private InvoicesToRegister GetSampleInvoiceData(int invoiceNumber)
        {
            var generatorTitle = new CompanyTitle(new LimitedString120("GENERATOR BCN 1, S.L."), new TaxPayerNumber("B65374811"));
            return new InvoicesToRegister(
                new Header(generatorTitle, CommunicationType.Registration),
                new[]
                {
                    new Invoice(
                        new TaxPeriod(new Year(2017), Month.December),
                        new InvoiceId(generatorTitle.TaxPayerNumber, new LimitedString1to60(invoiceNumber.ToString("D2")), new DateTime(2017,5,10)),
                        InvoiceType.Invoice,
                        SchemeOrEffect.GeneralTaxRegimeActivity,
                        new Amount(26.7M),
                        new LimitedString500("This is a test invoice."),
                        new CounterPartyCompany(new CompanyTitle(new LimitedString120("Microsoft test company"), new TaxPayerNumber("A08433179"))),
                        new BreakdownKind(new InvoiceBreakdown(new Item(new WithTaxItem(TransactionType.NotExempt, new []
                        {
                            new VATBreakdown(new Percentage(21), new Amount(22.07M), new Amount(4.63M))
                        }))))
                    )
                }
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
