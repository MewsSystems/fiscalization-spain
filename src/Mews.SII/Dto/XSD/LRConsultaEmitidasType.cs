﻿[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaEmitidasType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroEmitidasType FiltroConsulta { get; set; }
}