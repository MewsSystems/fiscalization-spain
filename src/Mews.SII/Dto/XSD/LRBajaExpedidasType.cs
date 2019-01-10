﻿[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaExpedidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }
}