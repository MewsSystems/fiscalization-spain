using System.Xml;
using System.Xml.Serialization;
using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroLR;
using Mews.Fiscalization.Spain.Environment;
using Xunit;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class Basics
    {
        [Fact]
        public void SendRevenueSimple()
        {
            var client = new SiiSoapClient();
            var data = new SuministroLRFacturasEmitidas
            {
                Cabecera = Credentials.GeneratorCabecera,
                RegistroLRFacturasEmitidas = new []{ new LRfacturasEmitidasType
                {
                    PeriodoLiquidacion = new RegistroSiiPeriodoLiquidacion(2017, TimePeriodType.May),
                    IDFactura = new IDFacturaExpedidaType
                    {
                        FechaExpedicionFacturaEmisor = "10-05-2017",
                        IDEmisorFactura = new IDFacturaExpedidaTypeIDEmisorFactura(Credentials.GeneratorNIF),
                        NumSerieFacturaEmisor = "05"
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

            var tmp = Test(Credentials.GeneratorCabecera);
            var tmp2 = Test(data);
            var response = client.SuministroLRFacturasEmitidas(data);

            Assert.NotNull(response);
            //Assert.NotNull(response.RespuestaLRFacturasEmitidas);
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
    }
}
