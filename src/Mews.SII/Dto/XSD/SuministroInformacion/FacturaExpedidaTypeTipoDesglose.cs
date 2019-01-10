﻿namespace Mews.Sii.Dto.XSD.SuministroInformacion
{
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
    public class FacturaExpedidaTypeTipoDesglose
    {
        [System.Xml.Serialization.XmlElementAttribute("DesgloseFactura", typeof(TipoSinDesgloseType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DesgloseTipoOperacion", typeof(TipoConDesgloseType), Order=0)]
        public object Item { get; set; }
    }
}