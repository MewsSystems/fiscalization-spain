using System;
using System.Linq;
using System.Threading.Tasks;
using Mews.Fiscalization.Spain.Communication;

namespace Mews.Fiscalization.Spain.Nif
{
    public class NifValidator
    {
        public NifValidator(TimeSpan httpTimeout)
        {
            var endpointUri = new Uri("https://www1.agenciatributaria.gob.es/wlpl/BURT-JDIT/ws/VNifV2SOAP");
            SoapClient = SoapClient.GetNifValidatorClient(endpointUri, httpTimeout);
        }
        private SoapClient SoapClient { get; }

        public async Task<Response> CheckNif(Request model)
        {
            var request = Convert(model);
            var response = await SoapClient.SendAsync<Entrada, Salida>(request).ConfigureAwait(continueOnCapturedContext: false);
            return Convert(response);
        }

        private Response Convert(Salida value)
        {
            return new Response(value.Contribuyente.Select(Convert));
        }

        private NifInfoResults Convert(VNifV2SalContribuyente value)
        {
            return new NifInfoResults(value.Nif, value.Nombre, value.Resultado);
        }

        private Entrada Convert(Request value)
        {
            return new Entrada
            {
                Contribuyente = value.Entries.Select(e => new VNifV2EntContribuyente
                {
                    Nombre = e.Name,
                    Nif = e.TaxId
                }).ToArray()
            };
        }
    }
}
