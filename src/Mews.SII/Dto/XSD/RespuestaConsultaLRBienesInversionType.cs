﻿[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRBienesInversionType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRBienesInversion", Order=0)]
    public RegistroRespuestaConsultaBienesType[] RegistroRespuestaConsultaLRBienesInversion { get; set; }
}