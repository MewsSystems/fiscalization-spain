﻿[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaOperacionesSegurosType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaOperacionesSegurosType1 DatosOperacionesSeguros { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoFactura2Type EstadoOperacionesSeguros { get; set; }
}