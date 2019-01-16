using Mews.Fiscalization.Spain.Dto.XSD.SuministroLR;

namespace Mews.Fiscalization.Spain.Dto.Requests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public class AnulacionLRFacturasEmitidasRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd", Order=0)]
        public BajaLRFacturasEmitidas BajaLRFacturasEmitidas;

        public AnulacionLRFacturasEmitidasRequest()
        {
        }

        public AnulacionLRFacturasEmitidasRequest(BajaLRFacturasEmitidas bajaLRFacturasEmitidas)
        {
            BajaLRFacturasEmitidas = bajaLRFacturasEmitidas;
        }
    }
}