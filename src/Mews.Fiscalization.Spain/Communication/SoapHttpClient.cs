using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FuncSharp;

namespace Mews.Fiscalization.Spain.Communication
{
    internal class SoapHttpClient
    {
        internal SoapHttpClient(Uri endpointUri, TimeSpan timeout, X509Certificate certificate = null)
        {
            EndpointUri = endpointUri;

            HttpClient = certificate.ToOption().Match(
                c =>
                {
                    var requestHandler = new WebRequestHandler();
                    requestHandler.ClientCertificates.Add(certificate);
                    return new HttpClient(requestHandler) { Timeout = timeout };
                },
                _ => new HttpClient { Timeout = timeout }
            );
        }

        internal event EventHandler<HttpRequestFinishedEventArgs> HttpRequestFinished;

        private Uri EndpointUri { get; }

        private HttpClient HttpClient { get; }

        internal async Task<string> SendAsync(string body)
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
    }
}