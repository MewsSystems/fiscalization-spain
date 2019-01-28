using System;
using System.Threading.Tasks;

namespace Mews.Fiscalization.Spain.Nif
{
    public class NifValidator
    {
        public NifValidator(TimeSpan httpTimeout)
        {
            var endpointUri = new Uri("https://www1.agenciatributaria.gob.es/wlpl/BURT-JDIT/ws/VNifV2SOAP");
            SoapClient = new SoapClient(endpointUri, certificate, httpTimeout);
        }
        private SoapClient SoapClient { get; }

        public async Task<VNifV2SalContribuyente[]> CheckNif(VNifV2EntContribuyente[] values)
        {
            Task task = null;
            await task;
            return null;
        }
    }
}
