using System;
using System.Threading.Tasks;
using System.Xml;
using Mews.Fiscalization.Spain.Events;

namespace Mews.Fiscalization.Spain.Communication
{
    public class SoapClient
    {
        public SoapClient(Uri endpointUri, Certificate certificate, TimeSpan httpTimeout)
        {
            HttpClient = new SoapHttpClient(certificate, endpointUri, httpTimeout);
            Certificate = certificate;
            XmlManipulator = new XmlManipulator();
            HttpClient.HttpRequestFinished += (sender, args) => HttpRequestFinished?.Invoke(this, args);
        }

        public event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        private SoapHttpClient HttpClient { get; }

        private Certificate Certificate { get; }

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
    }
}
