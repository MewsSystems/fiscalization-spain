using System.Xml.Serialization;
using Mews.Fiscalization.Spain.Dto.XSD.RespuestaSuministro;

namespace Mews.Fiscalization.Spain.Dto.Responses
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    public class SubmitInvoicesResponse
    {
        [XmlElement(ElementName = "RespuestaLRFacturasEmitidas", Namespace = "https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
        public RespuestaLRFEmitidasType Response { get; set; }
    }
}