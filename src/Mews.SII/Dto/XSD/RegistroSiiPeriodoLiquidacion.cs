﻿[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RegistroSiiPeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}