using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Mews.Fiscalization.Spain.Communication;
using Mews.Fiscalization.Spain.Dto.Requests;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroLR;
using Mews.Fiscalization.Spain.Environment;
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
            var data = GetSampleInvoiceData(6);

            var x = await client.SendRevenueAsync(new SubmitInvoicesRequest(data));
        }

        private string Test<T>(T value)
            where T : class
        {
            var xmlDocument = new XmlDocument();
            var navigator = xmlDocument.CreateNavigator();

            var nameSpaces = new XmlSerializerNamespaces();
            nameSpaces.Add("sii", "https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd");
            nameSpaces.Add("siiLR", "https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd");

            using (var writer = navigator.AppendChild())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, value, nameSpaces);
            }
            return xmlDocument.DocumentElement.OuterXml;
        }


        private SuministroLRFacturasEmitidas GetSampleInvoiceData(int invoiceNumber)
        {
            return new SuministroLRFacturasEmitidas
            {
                Cabecera = Credentials.GeneratorCabecera,
                RegistroLRFacturasEmitidas = new[]{ new LRfacturasEmitidasType
                {
                    PeriodoLiquidacion = new RegistroSiiPeriodoLiquidacion(2017, TimePeriodType.May),
                    IDFactura = new IDFacturaExpedidaType
                    {
                        FechaExpedicionFacturaEmisor = "10-05-2017",
                        IDEmisorFactura = new IDFacturaExpedidaTypeIDEmisorFactura(Credentials.GeneratorNIF),
                        NumSerieFacturaEmisor = invoiceNumber.ToString("D2")
                    },
                    FacturaExpedida = new FacturaExpedidaType
                    {
                        TipoFactura = ClaveTipoFacturaType.F1,
                        ClaveRegimenEspecialOTrascendencia = IdOperacionesTrascendenciaTributariaType.Item01,
                        ImporteTotal = "26.70",
                        DescripcionOperacion = "This is a test invoice.",
                        Contraparte = Credentials.MicrosoftCompany,
                        TipoDesglose = new FacturaExpedidaTypeTipoDesglose(new TipoSinDesgloseType
                        {
                            Sujeta = new SujetaType
                            {
                                NoExenta = new SujetaTypeNoExenta
                                {
                                    TipoNoExenta = TipoOperacionSujetaNoExentaType.S1,
                                    DesgloseIVA = new []
                                    {
                                        new DetalleIVAEmitidaType
                                        {
                                            TipoImpositivo = "21",
                                            BaseImponible = "22.07",
                                            CuotaRepercutida = "4.63"
                                        }
                                    }
                                }
                            }
                        })

                    }
                }}
            };
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
