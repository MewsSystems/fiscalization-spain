using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;

namespace Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices.Requests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public class SuministroLRFacturasEmitidasRequest
    {
        public SuministroLRFacturasEmitidasRequest()
        {
        }

        public SuministroLRFacturasEmitidasRequest(SuministroLRFacturasEmitidas suministroLRFacturasEmitidas)
        {
            SuministroLRFacturasEmitidas = suministroLRFacturasEmitidas;
        }

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd", Order = 0)]
        public SuministroLRFacturasEmitidas SuministroLRFacturasEmitidas { get; set; }
    }
}