﻿[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaFRecibidasType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaRecibidaBajaType[] RespuestaLinea { get; set; }
}