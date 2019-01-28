using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FuncSharp;

namespace Mews.Fiscalization.Spain.Communication
{
    internal class SoapClient
    {
        private SoapClient(Uri endpointUri, TimeSpan httpTimeout, X509Certificate certificate = null)
        {
            EndpointUri = endpointUri;

            HttpClient = certificate.ToOption().Match(
                c =>
                {
                    var requestHandler = new WebRequestHandler();
                    requestHandler.ClientCertificates.Add(certificate);
                    return new HttpClient(requestHandler) { Timeout = httpTimeout };
                },
                _ => new HttpClient { Timeout = httpTimeout }
            );
        }

        internal event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        internal event EventHandler<XmlMessageSerializedEventArgs> XmlMessageSerialized;

        private Uri EndpointUri { get; }

        private HttpClient HttpClient { get; }

        public static SoapClient GetNifValidatorClient(Uri endpointUri, TimeSpan httpTimeout)
        {
            return new SoapClient(endpointUri, httpTimeout);
        }

        public static SoapClient GetInvoicesClient(Uri endpointUri, TimeSpan httpTimeout, X509Certificate certificate)
        {
            if (certificate == null)
            {
                throw new ArgumentNullException(nameof(certificate));
            }
            return new SoapClient(endpointUri, httpTimeout, certificate);
        }

        internal async Task<TOut> SendAsync<TIn, TOut>(TIn messageBodyObject)
            where TIn : class, new()
            where TOut : class, new()
        {
            var messageBodyXmlElement = XmlManipulator.Serialize(messageBodyObject);
            XmlMessageSerialized?.Invoke(this, new XmlMessageSerializedEventArgs(messageBodyXmlElement));

            var soapMessage = new SoapMessage(messageBodyXmlElement);
            var xmlDocument = soapMessage.GetXmlDocument();
            var xml = xmlDocument.OuterXml;

            var response = await GetResponseAsync(xml).ConfigureAwait(continueOnCapturedContext: false);

            var soapBody = GetSoapBody(response);
            return XmlManipulator.Deserialize<TOut>(soapBody);
        }

        private async Task<string> GetResponseAsync(string body)
        {
            var requestContent = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var response = await HttpClient.PostAsync(EndpointUri, requestContent).ConfigureAwait(continueOnCapturedContext: false))
            {
                var result = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);

                stopwatch.Stop();
                var duration = stopwatch.ElapsedMilliseconds;
                HttpRequestFinished?.Invoke(this, new HttpRequestFinishedEventArgs(result, duration));

                return result;
            }
        }

        private XmlElement GetSoapBody(string soapXmlString)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(soapXmlString);

            var soapMessage = SoapMessage.FromSoapXml(xmlDocument);
            return soapMessage.Body.FirstChild as XmlElement;
        }
    }
}
