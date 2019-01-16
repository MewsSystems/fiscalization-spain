using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices.Requests;
using Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices.Responses;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Mews.Fiscalization.Spain.Events;

namespace Mews.Fiscalization.Spain.Communication
{
    public class SiiSoapClient
    {
        public SiiSoapClient(X509Certificate certificate, SiiEnvironment environment, TimeSpan httpTimeout)
        {
            Environment = environment;
            var domain = environment == SiiEnvironment.Production ? "www1.agenciatributaria.gob.es" : "www7.aeat.es";
            var endpointUri = new Uri($"https://{domain}/wlpl/SSII-FACT/ws/fe/SiiFactFEV1SOAP");
            Client = new SoapClient(endpointUri, certificate, httpTimeout);
            Client.HttpRequestFinished += (sender, args) => HttpRequestFinished?.Invoke(this, args);
        }

        public event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        public SiiEnvironment Environment { get; }

        private SoapClient Client { get; }

        public async Task<SuministroLRFacturasEmitidasResponse> SendRevenueAsync(SuministroLRFacturasEmitidas message)
        {
            var request = new SuministroLRFacturasEmitidasRequest(message);
            return await Client.SendAsync<SuministroLRFacturasEmitidasRequest, SuministroLRFacturasEmitidasResponse>(request).ConfigureAwait(continueOnCapturedContext: false);
        }
    }
}
