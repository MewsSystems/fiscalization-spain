﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;

namespace Mews.Fiscalization.Spain.Communication
{
    internal class SoapClient
    {
        internal SoapClient(Uri endpointUri, X509Certificate certificate, TimeSpan httpTimeout)
        {
            HttpClient = new SoapHttpClient(certificate, endpointUri, httpTimeout);
            HttpClient.HttpRequestFinished += (sender, args) => HttpRequestFinished?.Invoke(this, args);
        }

        internal event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        internal event EventHandler<XmlMessageSerializedEventArgs> XmlMessageSerialized;

        private SoapHttpClient HttpClient { get; }

        internal async Task<TOut> SendAsync<TIn, TOut>(TIn messageBodyObject)
            where TIn : class, new()
            where TOut : class, new()
        {
            var messageBodyXmlElement = XmlManipulator.Serialize(messageBodyObject);
            XmlMessageSerialized?.Invoke(this, new XmlMessageSerializedEventArgs(messageBodyXmlElement));

            var soapMessage = new SoapMessage(messageBodyXmlElement);
            var xmlDocument = soapMessage.GetXmlDocument();
            var xml = xmlDocument.OuterXml;

            var response = await HttpClient.SendAsync(xml).ConfigureAwait(continueOnCapturedContext: false);
            var soapBody = GetSoapBody(response);
            return XmlManipulator.Deserialize<TOut>(soapBody);
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
