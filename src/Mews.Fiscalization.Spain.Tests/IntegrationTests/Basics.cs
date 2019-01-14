using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices;
using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices.Requests;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Xunit;

namespace Mews.Fiscalization.Spain.Tests.IntegrationTests
{
    public class Basics
    {
        [Fact]
        public void SendRevenueSimple()
        {
            ISiiSOAPClient client = new SiiSoapClient();
            var invoicesIssued = new SuministroLRFacturasEmitidas();
            var request = new SuministroLRFacturasEmitidasRequest(invoicesIssued);

            var tmp = Test(invoicesIssued);
            var tmp2 = Test(request);
            
            var response = client.SuministroLRFacturasEmitidas(request);
            Assert.NotNull(response);
            Assert.NotNull(response.RespuestaLRFacturasEmitidas);
        }

        private string Test(object val)
        {
            var serialized = XmlManipulator.Serialize(val);
            var tmp = serialized.InnerXml;
            var tmp2 = serialized.InnerText;
            var tmp3 = serialized.ToString();
            var tmp4 = serialized.Value;

            return serialized.Value;
        }
    }
}
