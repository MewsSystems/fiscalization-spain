﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FuncSharp;
using Mews.Fiscalization.Spain.Communication;
using Mews.Fiscalization.Spain.Converters;
using Mews.Fiscalization.Spain.Dto.Requests;
using Mews.Fiscalization.Spain.Dto.Responses;
using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain
{
    public class Client
    {
        public Client(X509Certificate certificate, Environment environment, TimeSpan httpTimeout)
        {
            var domain = environment.Match(
                Environment.Test, _ => "www7.aeat.es",
                Environment.Production, _ => "www1.agenciatributaria.gob.es"
            );
            var endpointUri = new Uri($"https://{domain}/wlpl/SSII-FACT/ws/fe/SiiFactFEV1SOAP");
            SoapClient = new SoapClient(endpointUri, certificate, httpTimeout);
            SoapClient.HttpRequestFinished += (sender, args) => HttpRequestFinished?.Invoke(this, args);
        }

        public event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        private SoapClient SoapClient { get; }

        public async Task<object> SendRevenueAsync(InvoicesToRegister model)
        {
            var request = new ModelToDtoConverter().Convert(model);
            var response = await SoapClient.SendAsync<SubmitIssuedInvoicesRequest, SubmitInvoicesResponse>(request).ConfigureAwait(continueOnCapturedContext: false);
            return new DtoToModelConverter().Convert(response);
        }
    }
}