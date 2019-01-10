﻿[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaPagosType))]
[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaFacturaPagosType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public IndicadorPaginacionType IndicadorPaginacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}