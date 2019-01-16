using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;
using Mews.Fiscalization.Spain.Events;

namespace Mews.Fiscalization.Spain.Communication
{
    public class SoapClient
    {
        public SoapClient(Uri endpointUri, X509Certificate certificate, TimeSpan httpTimeout)
        {
            HttpClient = new SoapHttpClient(certificate, endpointUri, httpTimeout);
            XmlManipulator = new XmlManipulator();
            HttpClient.HttpRequestFinished += (sender, args) => HttpRequestFinished?.Invoke(this, args);
        }

        public event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        private SoapHttpClient HttpClient { get; }

        private XmlManipulator XmlManipulator { get; }

        public async Task<TOut> SendAsync<TIn, TOut>(TIn messageBodyObject)
            where TIn : class, new()
            where TOut : class, new()
        {
            var messageBodyXmlElement = XmlManipulator.Serialize(messageBodyObject);

            var soapMessage = new SoapMessage(new SoapMessagePart(messageBodyXmlElement));
            var xmlDocument = soapMessage.GetXmlDocument();
            var xml = xmlDocument.OuterXml;
            Console.WriteLine("Created soap request. " + xml);

            var response = await HttpClient.SendAsync(xml).ConfigureAwait(continueOnCapturedContext: false);

            var soapBody = GetSoapBody(response);
            return XmlManipulator.Deserialize<TOut>(soapBody);
        }

        private XmlElement GetSoapBody(string soapXmlString)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(soapXmlString);

            var soapMessage = SoapMessage.FromSoapXml(xmlDocument);
            return soapMessage.Body.XmlElement.FirstChild as XmlElement;
        }

        private string WorkingRequest()
        {
            return @"<?xml version=""1.0"" encoding=""UTF-8""?>
<soapenv:Envelope 
	xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
	xmlns:sii=""https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd"" 
	xmlns:siiLR=""https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd"">
   <soapenv:Header />
   <soapenv:Body>
      <siiLR:SuministroLRFacturasEmitidas>
         <sii:Cabecera>
            <sii:IDVersionSii>1.1</sii:IDVersionSii>
            <sii:Titular>
               <sii:NombreRazon>GENERATOR BCN 1, S.L.</sii:NombreRazon>
               <sii:NIF>B65374811</sii:NIF>
            </sii:Titular>
            <sii:TipoComunicacion>A0</sii:TipoComunicacion>
         </sii:Cabecera>
         <siiLR:RegistroLRFacturasEmitidas>
            <sii:PeriodoLiquidacion>
               <sii:Ejercicio>2017</sii:Ejercicio>
               <sii:Periodo>05</sii:Periodo>
            </sii:PeriodoLiquidacion>
            <siiLR:IDFactura>
               <sii:IDEmisorFactura>
                  <sii:NIF>B65374811</sii:NIF>
               </sii:IDEmisorFactura>
               <sii:NumSerieFacturaEmisor>08</sii:NumSerieFacturaEmisor>
               <sii:FechaExpedicionFacturaEmisor>10-05-2017</sii:FechaExpedicionFacturaEmisor>
            </siiLR:IDFactura>
            <siiLR:FacturaExpedida>
               <sii:TipoFactura>F1</sii:TipoFactura>
               <sii:ClaveRegimenEspecialOTrascendencia>01</sii:ClaveRegimenEspecialOTrascendencia>
               <sii:ImporteTotal>26.70</sii:ImporteTotal>
               <sii:DescripcionOperacion>This is a test invoice.</sii:DescripcionOperacion>
               <sii:Contraparte>
                  <sii:NombreRazon>Microsoft test company</sii:NombreRazon>
                  <sii:NIF>A08433179</sii:NIF>
               </sii:Contraparte>
               <sii:TipoDesglose>
                  <sii:DesgloseFactura>
                     <sii:Sujeta>
                        <sii:NoExenta>
                           <sii:TipoNoExenta>S1</sii:TipoNoExenta>
                           <sii:DesgloseIVA>
                              <sii:DetalleIVA>
                                 <sii:TipoImpositivo>21</sii:TipoImpositivo>
                                 <sii:BaseImponible>22.07</sii:BaseImponible>
                                 <sii:CuotaRepercutida>4.63</sii:CuotaRepercutida>
                              </sii:DetalleIVA>
                           </sii:DesgloseIVA>
                        </sii:NoExenta>
                     </sii:Sujeta>
                  </sii:DesgloseFactura>
               </sii:TipoDesglose>
            </siiLR:FacturaExpedida>
         </siiLR:RegistroLRFacturasEmitidas>
         <siiLR:RegistroLRFacturasEmitidas>
            <sii:PeriodoLiquidacion>
               <sii:Ejercicio>2017</sii:Ejercicio>
               <sii:Periodo>05</sii:Periodo>
            </sii:PeriodoLiquidacion>
            <siiLR:IDFactura>
               <sii:IDEmisorFactura>
                  <sii:NIF>B65374811</sii:NIF>
               </sii:IDEmisorFactura>
               <sii:NumSerieFacturaEmisor>04</sii:NumSerieFacturaEmisor>
               <sii:FechaExpedicionFacturaEmisor>10-05-2017</sii:FechaExpedicionFacturaEmisor>
            </siiLR:IDFactura>
            <siiLR:FacturaExpedida>
               <sii:TipoFactura>F2</sii:TipoFactura>
               <sii:ClaveRegimenEspecialOTrascendencia>01</sii:ClaveRegimenEspecialOTrascendencia>
               <sii:ImporteTotal>50</sii:ImporteTotal>
               <sii:DescripcionOperacion>VentaYYYYYYY</sii:DescripcionOperacion>
               <sii:TipoDesglose>
                  <sii:DesgloseFactura>
                     <sii:Sujeta>
                        <sii:NoExenta>
                           <sii:TipoNoExenta>S1</sii:TipoNoExenta>
                           <sii:DesgloseIVA>
                              <sii:DetalleIVA>
                                 <sii:TipoImpositivo>21</sii:TipoImpositivo>
                                 <sii:BaseImponible>10</sii:BaseImponible>
                                 <sii:CuotaRepercutida>2.1</sii:CuotaRepercutida>
                              </sii:DetalleIVA>
                           </sii:DesgloseIVA>
                        </sii:NoExenta>
                     </sii:Sujeta>
                  </sii:DesgloseFactura>
               </sii:TipoDesglose>
            </siiLR:FacturaExpedida>
         </siiLR:RegistroLRFacturasEmitidas>
      </siiLR:SuministroLRFacturasEmitidas>
   </soapenv:Body>
</soapenv:Envelope>";
        }
    }
}
