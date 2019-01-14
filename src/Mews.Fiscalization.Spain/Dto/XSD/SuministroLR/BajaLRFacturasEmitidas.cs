using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;

namespace Mews.Fiscalization.Spain.Dto.XSD.SuministroLR
{
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
    public class BajaLRFacturasEmitidas : SuministroInformacionBaja
    {
        [System.Xml.Serialization.XmlElementAttribute("RegistroLRBajaExpedidas", Order=0)]
        public LRBajaExpedidasType[] RegistroLRBajaExpedidas { get; set; }
    }
}