using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FuncSharp;
using Mews.Fiscalization.Spain.Communication;

namespace Mews.Fiscalization.Spain.Nif
{
    public class NifValidator
    {
        public NifValidator(X509Certificate certificate, TimeSpan httpTimeout)
        {
            var endpointUri = new Uri("https://www1.agenciatributaria.gob.es/wlpl/BURT-JDIT/ws/VNifV2SOAP");
            SoapClient = new SoapClient(endpointUri, certificate, httpTimeout);
        }
        private SoapClient SoapClient { get; }

        public async Task<Response> CheckNif(Request model)
        {
            var request = Convert(model);
            var response = await SoapClient.SendAsync<Entrada, Salida>(request).ConfigureAwait(continueOnCapturedContext: false);
            return Convert(request, response);
        }

        private Response Convert(Entrada request, Salida response)
        {
            return new Response(response.Contribuyente.Select(r =>
            {
                var lowerCaseResult = r.Resultado?.ToLowerInvariant();
                var result = lowerCaseResult.Match(
                    "identificado", _ => request.Contribuyente.Any(i => i.Nif == r.Nif).Match(
                        t => NifSearchResult.Found,
                        f => NifSearchResult.FoundButNifModifiedByServer
                    ),
                    "no identificado", _ => NifSearchResult.NotFound,
                    "no procesado", _ => NifSearchResult.NotProcessed,
                    _ => NifSearchResult.Other
                );
                return new NifInfoResults(r.Nif, r.Nombre, result, r.Resultado);
            }));
        }

        private Entrada Convert(Request value)
        {
            return new Entrada
            {
                Contribuyente = value.Entries.Select(e => new VNifV2EntContribuyente
                {
                    Nombre = e.Name,
                    Nif = e.TaxpayerNumber.TaxpayerNumber
                }).ToArray()
            };
        }
    }
}
