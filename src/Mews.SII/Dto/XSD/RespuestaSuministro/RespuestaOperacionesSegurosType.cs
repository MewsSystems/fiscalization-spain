﻿using Mews.Sii.Dto.XSD.SuministroInformacion;

namespace Mews.Sii.Dto.XSD.RespuestaSuministro
{
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
    public class RespuestaOperacionesSegurosType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RespuestaOperacionesSegurosTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PersonaFisicaJuridicaType Contraparte { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ClaveOperacionType ClaveOperacion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public EstadoRegistroType EstadoRegistro { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=4)]
        public string CodigoErrorRegistro { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string DescripcionErrorRegistro { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string CSV { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public RegistroDuplicadoType RegistroDuplicado { get; set; }
    }
}