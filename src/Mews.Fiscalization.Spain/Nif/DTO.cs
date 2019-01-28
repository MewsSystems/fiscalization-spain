using System.Xml.Serialization;

namespace Mews.Fiscalization.Spain.Nif
{
    [XmlRoot(ElementName = "VNifV2EntContribuyente", Namespace = "http://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/burt/jdit/ws/VNifV2Ent.xsd")]
    [XmlType(AnonymousType = true, Namespace = "http://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/burt/jdit/ws/VNifV2Ent.xsd")]
    public class VNifV2EntContribuyente
    {
        [XmlElement(Order=0)]
        public string Nif { get; set; }

        [XmlElement(Order=1)]
        public string Nombre { get; set; }
    }

    [XmlType(AnonymousType=true, Namespace="http://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/burt/jdit/ws/VNifV2Sal.xsd")]
    public class VNifV2SalContribuyente
    {
        [XmlElement(Order=0)]
        public string Nif { get; set; }

        [XmlElement(Order=1)]
        public string Nombre { get; set; }

        [XmlElement(Order=2)]
        public string Resultado { get; set; }
    }

    public class Entrada
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/burt/jdit/ws/VNifV2Ent.xsd", Order = 0)]
        [XmlArrayItem("Contribuyente", IsNullable = false)]
        public VNifV2EntContribuyente[] Contribuyente { get; set; }
    }

    public class Salida
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/burt/jdit/ws/VNifV2Sal.xsd", Order=0)]
        [XmlArrayItem("Contribuyente", IsNullable=false)]
        public VNifV2SalContribuyente[] Contribuyente { get; set; }
    }
}