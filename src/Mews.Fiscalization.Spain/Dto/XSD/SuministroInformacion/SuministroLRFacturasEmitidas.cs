using Mews.Fiscalization.Spain.Dto.XSD.SuministroLR;

namespace Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion
{
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
    public class SuministroLRFacturasEmitidas : SuministroInformacion
    {
        [System.Xml.Serialization.XmlElementAttribute("RegistroLRFacturasEmitidas", Order=0)]
        public LRfacturasEmitidasType[] RegistroLRFacturasEmitidas { get; set; }
    }
}