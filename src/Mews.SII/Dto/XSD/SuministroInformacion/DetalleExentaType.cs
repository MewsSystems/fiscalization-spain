﻿namespace Mews.Sii.Dto.XSD.SuministroInformacion
{
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
    public class DetalleExentaType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CausaExencionType CausaExencion { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool CausaExencionSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string BaseImponible { get; set; }
    }
}