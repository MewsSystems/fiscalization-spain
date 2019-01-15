﻿using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Events;

namespace Mews.Fiscalization.Spain.Communication
{
    public class SoapHttpClient
    {
        public SoapHttpClient(Certificate certificate, Uri endpointUri, TimeSpan timeout)
        {
            EndpointUri = endpointUri;

            var requestHandler = new WebRequestHandler();
            requestHandler.ClientCertificates.Add(certificate.X509Certificate2);
            HttpClient = new HttpClient(requestHandler) { Timeout = timeout };
        }

        public event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        private Uri EndpointUri { get; }

        private HttpClient HttpClient { get; }

        public async Task<string> SendAsync(string body)
        {
            var requestContent = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            using (var response = await HttpClient.PostAsync(EndpointUri, requestContent).ConfigureAwait(continueOnCapturedContext: false))
            {
                var result = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);

                stopwatch.Stop();
                var duration = stopwatch.ElapsedMilliseconds;
                HttpRequestFinished?.Invoke(this, new HttpRequestFinishedEventArgs(duration));

                return result;
            }
        }
    }
}