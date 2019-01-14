using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices;
using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices.Requests;
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
            ISiiSOAPClient client = new SiiSoapClient();
            var client2 = new SiiSoapClient();
            var request = new SuministroLRFacturasEmitidasRequest(new SuministroLRFacturasEmitidas
            {
                Cabecera = Credentials.GeneratorCabecera,
                RegistroLRFacturasEmitidas = new []{ new LRfacturasEmitidasType
                {
                    PeriodoLiquidacion = new RegistroSiiPeriodoLiquidacion(2017, TimePeriodType.May),
                    IDFactura = new IDFacturaExpedidaType
                    {
                        FechaExpedicionFacturaEmisor = "10-05-2017",
                        IDEmisorFactura = new IDFacturaExpedidaTypeIDEmisorFactura(Credentials.GeneratorNIF),
                        NumSerieFacturaEmisor = "03"
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
            });

            var tmp2 = Test(request);
            var response2 = client.SuministroLRFacturasEmitidas(request);
            //Assert.NotNull(response);
            //Assert.NotNull(response.RespuestaLRFacturasEmitidas);
        }

        private string Test<T>(T val)
            where T : class
        {
            var serialized = XmlManipulator.Serialize(val);
            var tmp = serialized.InnerXml;
            var tmp2 = serialized.OuterXml;
            var tmp3 = serialized.InnerText;
            var tmp4 = serialized.ToString();
            var tmp5 = serialized.Value;

            return serialized.OuterXml;
        }
    }
}
