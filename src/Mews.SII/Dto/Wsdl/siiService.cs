[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroFactEmitidas.wsdl", ConfigurationName="siiSOAP")]
public interface siiSOAP
{
    
    // CODEGEN: Generating message contract since the operation SuministroLRFacturasEmitidas is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSiiImputacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacionCliente))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaRespuestaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunBajaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacionBaja))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunAltaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSii))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacion))]
    SuministroLRFacturasEmitidasResponse SuministroLRFacturasEmitidas(SuministroLRFacturasEmitidasRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<SuministroLRFacturasEmitidasResponse> SuministroLRFacturasEmitidasAsync(SuministroLRFacturasEmitidasRequest request);
    
    // CODEGEN: Generating message contract since the operation AnulacionLRFacturasEmitidas is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSiiImputacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacionCliente))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaRespuestaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunBajaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacionBaja))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunAltaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSii))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacion))]
    AnulacionLRFacturasEmitidasResponse AnulacionLRFacturasEmitidas(AnulacionLRFacturasEmitidasRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<AnulacionLRFacturasEmitidasResponse> AnulacionLRFacturasEmitidasAsync(AnulacionLRFacturasEmitidasRequest request);
    
    // CODEGEN: Generating message contract since the operation ConsultaLRFacturasEmitidas is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSiiImputacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacionCliente))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaRespuestaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunBajaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacionBaja))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunAltaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSii))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacion))]
    ConsultaLRFacturasEmitidasResponse ConsultaLRFacturasEmitidas(ConsultaLRFacturasEmitidasRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<ConsultaLRFacturasEmitidasResponse> ConsultaLRFacturasEmitidasAsync(ConsultaLRFacturasEmitidasRequest request);
    
    // CODEGEN: Generating message contract since the operation ConsultaLRFactInformadasCliente is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSiiImputacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacionCliente))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaRespuestaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunBajaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacionBaja))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunAltaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSii))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacion))]
    ConsultaLRFactInformadasClienteResponse ConsultaLRFactInformadasCliente(ConsultaLRFactInformadasClienteRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<ConsultaLRFactInformadasClienteResponse> ConsultaLRFactInformadasClienteAsync(ConsultaLRFactInformadasClienteRequest request);
    
    // CODEGEN: Generating message contract since the operation ConsultaLRFactInformadasAgrupadasCliente is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSiiImputacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacionCliente))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaRespuestaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsultaInformacion))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunBajaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacionBaja))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RespuestaComunAltaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FacturaType))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistroSii))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SuministroInformacion))]
    ConsultaLRFactInformadasAgrupadasClienteResponse ConsultaLRFactInformadasAgrupadasCliente(ConsultaLRFactInformadasAgrupadasClienteRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<ConsultaLRFactInformadasAgrupadasClienteResponse> ConsultaLRFactInformadasAgrupadasClienteAsync(ConsultaLRFactInformadasAgrupadasClienteRequest request);
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class SuministroLRFacturasEmitidas : SuministroInformacion
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroLRFacturasEmitidas", Order=0)]
    public LRfacturasEmitidasType[] RegistroLRFacturasEmitidas { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRfacturasEmitidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public FacturaExpedidaType FacturaExpedida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaExpedidaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string NumSerieFacturaEmisorResumenFin { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaExpedidaTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NIF { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaFactInformadasAgrupadasClienteType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaUnicaESType Cliente { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumeroFacturas { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class PersonaFisicaJuridicaUnicaESType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NIF { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class EstadoFacturaImputacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EstadoCuadreType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string TimestampEstadoCuadre { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum EstadoCuadreType
{
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaImputacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaImputacionTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string NumSerieFacturaEmisorResumenFin { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaImputacionTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NIF { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaFactInformadasClienteType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaImputacionType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RegistroRespuestaConsultaFactInformadasClienteTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public FacturaRespuestaInformadaClienteType DatosFacturaInformadaCliente { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public PersonaFisicaJuridicaUnicaESType Cliente { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public EstadoFacturaImputacionType EstadoFactura { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaFactInformadasClienteTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum TipoPeriodoType
{
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    Item06,
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    Item07,
    [System.Xml.Serialization.XmlEnumAttribute("08")]
    Item08,
    [System.Xml.Serialization.XmlEnumAttribute("09")]
    Item09,
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,
    [System.Xml.Serialization.XmlEnumAttribute("0A")]
    Item0A,
    [System.Xml.Serialization.XmlEnumAttribute("1T")]
    Item1T,
    [System.Xml.Serialization.XmlEnumAttribute("2T")]
    Item2T,
    [System.Xml.Serialization.XmlEnumAttribute("3T")]
    Item3T,
    [System.Xml.Serialization.XmlEnumAttribute("4T")]
    Item4T,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaInformadaClienteType : FacturaRespuestaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DesgloseFacturaRecibidasType DesgloseFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string FechaRegContable { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public FacturaARType Pagos { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DesgloseFacturaRecibidasType
{
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleIVA", IsNullable=false)]
    public DetalleIVARecibida2Type[] InversionSujetoPasivo { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleIVA", IsNullable=false)]
    public DetalleIVARecibidaType[] DesgloseIVA { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DetalleIVARecibida2Type
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string TipoImpositivo { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BaseImponible { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string CuotaSoportada { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string TipoRecargoEquivalencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string CuotaRecargoEquivalencia { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DetalleIVARecibidaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string TipoImpositivo { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BaseImponible { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string CuotaSoportada { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string TipoRecargoEquivalencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string CuotaRecargoEquivalencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string PorcentCompensacionREAGYP { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string ImporteCompensacionREAGYP { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public enum FacturaARType
{
    S,
    N,
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(FacturaRespuestaInformadaProveedorType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FacturaRespuestaInformadaClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FacturaRespuestaRecibidaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FacturaRespuestaExpedidaType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ClaveTipoFacturaType TipoFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveTipoRectificativaType TipoRectificativa { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoRectificativaSpecified { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("IDFacturaAgrupada", IsNullable=false)]
    public IDFacturaARType[] FacturasAgrupadas { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("IDFacturaRectificada", IsNullable=false)]
    public IDFacturaARType[] FacturasRectificadas { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public DesgloseRectificacionType ImporteRectificacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string FechaOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenEspecialOTrascendencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenEspecialOTrascendenciaAdicional1 { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClaveRegimenEspecialOTrascendenciaAdicional1Specified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenEspecialOTrascendenciaAdicional2 { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClaveRegimenEspecialOTrascendenciaAdicional2Specified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string NumRegistroAcuerdoFacturacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string BaseImponibleACoste { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public string DescripcionOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("FacturaSimplificadaArticulos7.2_7.3", Order=14)]
    public SimplificadaCualificadaType FacturaSimplificadaArticulos72_73 { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaSimplificadaArticulos72_73Specified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public RegPrevioGGEEoREDEMEoCompetenciaType RegPrevioGGEEoREDEMEoCompetencia { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RegPrevioGGEEoREDEMEoCompetenciaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public MacrodatoType Macrodato { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MacrodatoSpecified { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum ClaveTipoFacturaType
{
    F1,
    F2,
    R1,
    R2,
    R3,
    R4,
    R5,
    F3,
    F4,
    F5,
    F6,
    LC,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum ClaveTipoRectificativaType
{
    S,
    I,
    [System.Xml.Serialization.XmlEnumAttribute(" ")]
    Item,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaARType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DesgloseRectificacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string BaseRectificada { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string CuotaRectificada { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string CuotaRecargoRectificado { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum IdOperacionesTrascendenciaTributariaType
{
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    Item06,
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    Item07,
    [System.Xml.Serialization.XmlEnumAttribute("08")]
    Item08,
    [System.Xml.Serialization.XmlEnumAttribute("09")]
    Item09,
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,
    [System.Xml.Serialization.XmlEnumAttribute("13")]
    Item13,
    [System.Xml.Serialization.XmlEnumAttribute("14")]
    Item14,
    [System.Xml.Serialization.XmlEnumAttribute("15")]
    Item15,
    [System.Xml.Serialization.XmlEnumAttribute("16")]
    Item16,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum SimplificadaCualificadaType
{
    S,
    N,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum RegPrevioGGEEoREDEMEoCompetenciaType
{
    S,
    N,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum MacrodatoType
{
    S,
    N,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaInformadaProveedorType : FacturaRespuestaType
{
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleInmueble", IsNullable=false)]
    public DatosInmuebleType[] DatosInmueble { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTransmisionInmueblesSujetoAIVA { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EmitidaPorTercerosType EmitidaPorTercerosODestinatario { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EmitidaPorTercerosODestinatarioSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EmitidaPorTercerosType FacturacionDispAdicionalTerceraYsextayDelMercadoOrganizadoDelGas { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturacionDispAdicionalTerceraYsextayDelMercadoOrganizadoDelGasSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public VariosDestinatariosType VariosDestinatarios { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VariosDestinatariosSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public CuponType Cupon { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CuponSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("FacturaSinIdentifDestinatarioAritculo6.1.d", Order=6)]
    public CompletaSinDestinatarioType FacturaSinIdentifDestinatarioAritculo61d { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaSinIdentifDestinatarioAritculo61dSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public FacturaRespuestaInformadaProveedorTypeTipoDesglose TipoDesglose { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public FacturaARType Cobros { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DatosInmuebleType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public SituacionInmuebleType SituacionInmueble { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ReferenciaCatastral { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum SituacionInmuebleType
{
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum EmitidaPorTercerosType
{
    S,
    N,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum VariosDestinatariosType
{
    S,
    N,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum CuponType
{
    S,
    N,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum CompletaSinDestinatarioType
{
    S,
    N,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaInformadaProveedorTypeTipoDesglose
{
    [System.Xml.Serialization.XmlElementAttribute("DesgloseFactura", typeof(TipoSinDesgloseType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("DesgloseTipoOperacion", typeof(TipoConDesgloseType), Order=0)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class TipoSinDesgloseType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public SujetaType Sujeta { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public NoSujetaType NoSujeta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class SujetaType
{
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleExenta", IsNullable=false)]
    public DetalleExentaType[] Exenta { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public SujetaTypeNoExenta NoExenta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DetalleExentaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public CausaExencionType CausaExencion { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CausaExencionSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BaseImponible { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum CausaExencionType
{
    E1,
    E2,
    E3,
    E4,
    E5,
    E6,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class SujetaTypeNoExenta
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TipoOperacionSujetaNoExentaType TipoNoExenta { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleIVA", IsNullable=false)]
    public DetalleIVAEmitidaType[] DesgloseIVA { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum TipoOperacionSujetaNoExentaType
{
    S1,
    S2,
    S3,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DetalleIVAEmitidaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string TipoImpositivo { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BaseImponible { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string CuotaRepercutida { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string TipoRecargoEquivalencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string CuotaRecargoEquivalencia { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class NoSujetaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string ImportePorArticulos7_14_Otros { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTAIReglasLocalizacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class TipoConDesgloseType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TipoSinDesglosePrestacionType PrestacionServicios { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoSinDesgloseType Entrega { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class TipoSinDesglosePrestacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public SujetaPrestacionType Sujeta { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public NoSujetaType NoSujeta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class SujetaPrestacionType
{
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleExenta", IsNullable=false)]
    public DetalleExentaType[] Exenta { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public SujetaPrestacionTypeNoExenta NoExenta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class SujetaPrestacionTypeNoExenta
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TipoOperacionSujetaNoExentaType TipoNoExenta { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleIVA", IsNullable=false)]
    public DetalleIVAEmitidaPrestacionType[] DesgloseIVA { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DetalleIVAEmitidaPrestacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string TipoImpositivo { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BaseImponible { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string CuotaRepercutida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaRecibidaType : FacturaRespuestaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DesgloseFacturaRecibidasType DesgloseFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaRegContable { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string CuotaDeducible { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public FacturaARType Pagos { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class PersonaFisicaJuridicaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NIFRepresentante { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=2)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=2)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDOtroType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public CountryType2 CodigoPais { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CodigoPaisSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaIDTypeType IDType { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ID { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum CountryType2
{
    AF,
    AL,
    DE,
    AD,
    AO,
    AI,
    AQ,
    AG,
    SA,
    DZ,
    AR,
    AM,
    AW,
    AU,
    AT,
    AZ,
    BS,
    BH,
    BD,
    BB,
    BE,
    BZ,
    BJ,
    BM,
    BY,
    BO,
    BA,
    BW,
    BV,
    BR,
    BN,
    BG,
    BF,
    BI,
    BT,
    CV,
    KY,
    KH,
    CM,
    CA,
    CF,
    CC,
    CO,
    KM,
    CG,
    CD,
    CK,
    KP,
    KR,
    CI,
    CR,
    HR,
    CU,
    TD,
    CZ,
    CL,
    CN,
    CY,
    CW,
    DK,
    DM,
    DO,
    EC,
    EG,
    AE,
    ER,
    SK,
    SI,
    ES,
    US,
    EE,
    ET,
    FO,
    PH,
    FI,
    FJ,
    FR,
    GA,
    GM,
    GE,
    GS,
    GH,
    GI,
    GD,
    GR,
    GL,
    GU,
    GT,
    GG,
    GN,
    GQ,
    GW,
    GY,
    HT,
    HM,
    HN,
    HK,
    HU,
    IN,
    ID,
    IR,
    IQ,
    IE,
    IM,
    IS,
    IL,
    IT,
    JM,
    JP,
    JE,
    JO,
    KZ,
    KE,
    KG,
    KI,
    KW,
    LA,
    LS,
    LV,
    LB,
    LR,
    LY,
    LI,
    LT,
    LU,
    XG,
    MO,
    MK,
    MG,
    MY,
    MW,
    MV,
    ML,
    MT,
    FK,
    MP,
    MA,
    MH,
    MU,
    MR,
    YT,
    UM,
    MX,
    FM,
    MD,
    MC,
    MN,
    ME,
    MS,
    MZ,
    MM,
    NA,
    NR,
    CX,
    NP,
    NI,
    NE,
    NG,
    NU,
    NF,
    NO,
    NC,
    NZ,
    IO,
    OM,
    NL,
    BQ,
    PK,
    PW,
    PA,
    PG,
    PY,
    PE,
    PN,
    PF,
    PL,
    PT,
    PR,
    QA,
    GB,
    RW,
    RO,
    RU,
    SB,
    SV,
    WS,
    AS,
    KN,
    SM,
    SX,
    PM,
    VC,
    SH,
    LC,
    ST,
    SN,
    RS,
    SC,
    SL,
    SG,
    SY,
    SO,
    LK,
    SZ,
    ZA,
    SD,
    SS,
    SE,
    CH,
    SR,
    TH,
    TW,
    TZ,
    TJ,
    PS,
    TF,
    TL,
    TG,
    TK,
    TO,
    TT,
    TN,
    TC,
    TM,
    TR,
    TV,
    UA,
    UG,
    UY,
    UZ,
    VU,
    VA,
    VE,
    VN,
    VG,
    VI,
    WF,
    YE,
    DJ,
    ZM,
    ZW,
    QU,
    XB,
    XU,
    XN,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum PersonaFisicaJuridicaIDTypeType
{
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    Item06,
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    Item07,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaExpedidaType : FacturaRespuestaType
{
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleInmueble", IsNullable=false)]
    public DatosInmuebleType[] DatosInmueble { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTransmisionInmueblesSujetoAIVA { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EmitidaPorTercerosType EmitidaPorTercerosODestinatario { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EmitidaPorTercerosODestinatarioSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EmitidaPorTercerosType FacturacionDispAdicionalTerceraYsextayDelMercadoOrganizadoDelGas { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturacionDispAdicionalTerceraYsextayDelMercadoOrganizadoDelGasSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public VariosDestinatariosType VariosDestinatarios { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VariosDestinatariosSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public CuponType Cupon { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CuponSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("FacturaSinIdentifDestinatarioAritculo6.1.d", Order=6)]
    public CompletaSinDestinatarioType FacturaSinIdentifDestinatarioAritculo61d { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaSinIdentifDestinatarioAritculo61dSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public FacturaRespuestaExpedidaTypeTipoDesglose TipoDesglose { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public FacturaARType Cobros { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class FacturaRespuestaExpedidaTypeTipoDesglose
{
    [System.Xml.Serialization.XmlElementAttribute("DesgloseFactura", typeof(TipoSinDesgloseType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("DesgloseTipoOperacion", typeof(TipoConDesgloseType), Order=0)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ClavePaginacionProveedorType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ClavePaginacionProveedorTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ClavePaginacionProveedorTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NIF { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ClavePaginacionClienteType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ClavePaginacionClienteTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public PersonaFisicaJuridicaUnicaESType Cliente { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ClavePaginacionClienteTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NIF { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RangoFechaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Desde { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Hasta { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroFactInformadasAgrupadasProveedorType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroFactInformadasProveedorType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroFactInformadasAgrupadasClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroFactInformadasClienteType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RegistroSiiImputacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RegistroSiiImputacionPeriodoImputacion PeriodoImputacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RegistroSiiImputacionPeriodoImputacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string EjercicioImputacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType PeriodoImputacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroFactInformadasAgrupadasProveedorType : RegistroSiiImputacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaUnicaESType Proveedor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EstadoCuadreImputacionType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum EstadoCuadreImputacionType
{
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroFactInformadasProveedorType : RegistroSiiImputacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaUnicaESType Proveedor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoCuadreImputacionType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public RangoFechaType FechaExpedicion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public RangoFechaType FechaOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public ClavePaginacionProveedorType ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroFactInformadasAgrupadasClienteType : RegistroSiiImputacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaUnicaESType Cliente { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EstadoCuadreImputacionType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroFactInformadasClienteType : RegistroSiiImputacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaUnicaESType Cliente { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoCuadreImputacionType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public RangoFechaType FechaExpedicion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public RangoFechaType FechaOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public ClavePaginacionClienteType ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class CabeceraConsultaSiiCliente
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public VersionSiiType IDVersionSii { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaUnicaESType TitularLRFE { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum VersionSiiType
{
    [System.Xml.Serialization.XmlEnumAttribute("1.1")]
    Item11,
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasAgrupadasClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFactInformadasAgrupadasClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFactInformadasClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsultaLRFactInformadasAgrupadasClienteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsultaLRFactInformadasClienteType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ConsultaInformacionCliente
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public CabeceraConsultaSiiCliente Cabecera { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFactInformadasAgrupadasClienteType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFacturasAgrupadasClienteType : ConsultaInformacionCliente
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public enum ResultadoConsultaType
{
    ConDatos,
    SinDatos,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFactInformadasAgrupadasClienteType : RespuestaConsultaLRFacturasAgrupadasClienteType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRFactInformadasAgrupadasCliente", Order=0)]
    public RegistroRespuestaConsultaFactInformadasAgrupadasClienteType[] RegistroRespuestaConsultaLRFactInformadasAgrupadasCliente { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFactInformadasClienteType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFacturasClienteType : ConsultaInformacionCliente
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IndicadorPaginacionType IndicadorPaginacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public enum IndicadorPaginacionType
{
    S,
    N,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFactInformadasClienteType : RespuestaConsultaLRFacturasClienteType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRFactInformadasCliente", Order=0)]
    public RegistroRespuestaConsultaFactInformadasClienteType[] RegistroRespuestaConsultaLRFactInformadasCliente { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class ConsultaLRFactInformadasAgrupadasClienteType : ConsultaInformacionCliente
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroFactInformadasAgrupadasClienteType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class ConsultaLRFactInformadasClienteType : ConsultaInformacionCliente
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroFactInformadasClienteType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaPagosType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DatosPagoCobroType DatosPago { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DatosPagoCobroType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Fecha { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Importe { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public MedioPagoType Medio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string Cuenta_O_Medio { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum MedioPagoType
{
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DatosPresentacion2Type
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NIFPresentador { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string TimestampPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaInmueblesAdicionalesType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DatosInmuebleType DatosInmueblesAdicionales { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaCobrosType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DatosPagoCobroType DatosCobro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(TypeName="RespuestaOperacionesSegurosType", Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaOperacionesSegurosType1
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveOperacionType ClaveOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum ClaveOperacionType
{
    A,
    B,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaOperacionesSegurosType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaOperacionesSegurosType1 DatosOperacionesSeguros { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoFactura2Type EstadoOperacionesSeguros { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class EstadoFactura2Type
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string TimestampUltimaModificacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EstadoRegistroSIIType1 EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=2)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string DescripcionErrorRegistro { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="EstadoRegistroSIIType", Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public enum EstadoRegistroSIIType1
{
    Correcta,
    AceptadaConErrores,
    Anulada,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaAgenciasViajesType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaCobrosMetalicoType DatosAgenciasViajes { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoFactura2Type EstadoAgenciasViajes { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaCobrosMetalicoType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaCobrosMetalicoType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaCobrosMetalicoType DatosCobroMetalico { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoFactura2Type EstadoCobroMetalico { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaDetOperIntracomunitariaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public OperacionIntracomunitariaType DetOperIntracomunitarias { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class OperacionIntracomunitariaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public OperacionIntracomunitariaTypeTipoOperacion TipoOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public OperacionIntracomunitariaTypeClaveDeclarado ClaveDeclarado { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public CountryMiembroType EstadoMiembro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string PlazoOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionBienes { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string DireccionOperador { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string FacturasODocumentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string NumRegistroAcuerdoFacturacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public RegPrevioGGEEoREDEMEoCompetenciaType RegPrevioGGEEoREDEMEoCompetencia { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RegPrevioGGEEoREDEMEoCompetenciaSpecified { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum OperacionIntracomunitariaTypeTipoOperacion
{
    A,
    B,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum OperacionIntracomunitariaTypeClaveDeclarado
{
    D,
    R,
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum CountryMiembroType
{
    DE,
    AT,
    BE,
    BG,
    CZ,
    CY,
    HR,
    DK,
    SK,
    SI,
    EE,
    FI,
    FR,
    GR,
    HU,
    IE,
    IT,
    LV,
    LT,
    LU,
    MT,
    NL,
    PL,
    PT,
    GB,
    RO,
    SE,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaDetOperIntracomunitariasType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RespuestaDetOperIntracomunitariaType DatosDetOperIntracomunitarias { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoFactura2Type EstadoFactura { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaComunitariaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaComunitariaTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=1)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=1)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaBienesType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public BienDeInversionType DatosBienInversion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoFactura2Type EstadoFactura { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class BienDeInversionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string IdentificacionBien { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string FechaInicioUtilizacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ProrrataAnualDefinitiva { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string RegularizacionAnualDeduccion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string IdentificacionEntrega { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string RegularizacionDeduccionEfectuada { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string NumRegistroAcuerdoFacturacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaRecibidasType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public FacturaRespuestaRecibidaType DatosFacturaRecibida { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoFacturaType EstadoFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public DatosDescuadreContraparteType DatosDescuadreContraparte { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaRecibidaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string NumSerieFacturaEmisorResumenFin { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaRecibidaTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=0)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class EstadoFacturaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EstadoCuadreType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string TimestampEstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string TimestampUltimaModificacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoRegistroSIIType1 EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=4)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string DescripcionErrorRegistro { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class DatosDescuadreContraparteType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string SumBaseImponibleISP { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string SumBaseImponible { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string SumCuota { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string SumCuotaRecargoEquivalencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string ImporteTotal { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RegistroRespuestaConsultaEmitidasType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public FacturaRespuestaExpedidaType DatosFacturaEmitida { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public DatosPresentacion2Type DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoFacturaType EstadoFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public DatosDescuadreContraparteType DatosDescuadreContraparte { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroInmueblesAdicionalesType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCType IDFactura { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaExpedidaBCType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaExpedidaBCTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NIF { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroPagosType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public double ClavePaginacion { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClavePaginacionSpecified { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaRecibidaNombreBCType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaRecibidaNombreBCTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=1)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=1)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroCobrosType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public double ClavePaginacion { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClavePaginacionSpecified { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class CabeceraConsultaSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public VersionSiiType IDVersionSii { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaUnicaESType Titular { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaFacturaPagosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaPagosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaInmueblesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaInmueblesAdicionalesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaFacturaCobrosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaCobrosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLROperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRCobrosMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRDetOperIntracomunitariasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasEmitidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsultaInmueblesAdicionalesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsultaPagosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsultaCobrosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaLROperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaCobrosMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaDetOperIntracomunitariasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaEmitidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRConsultaRecibidasType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public CabeceraConsultaSii Cabecera { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaPagosType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaFacturaPagosType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public IndicadorPaginacionType IndicadorPaginacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaPagosType : RespuestaConsultaFacturaPagosType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaPagos", Order=0)]
    public RegistroRespuestaConsultaPagosType[] RegistroRespuestaConsultaPagos { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public double ClavePaginacion { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClavePaginacionSpecified { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaInmueblesAdicionalesType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaInmueblesType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaInmueblesAdicionalesType : RespuestaConsultaInmueblesType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaInmueblesAdicionales", Order=0)]
    public RegistroRespuestaConsultaInmueblesAdicionalesType[] RegistroRespuestaConsultaInmueblesAdicionales { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaCobrosType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaFacturaCobrosType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public IndicadorPaginacionType IndicadorPaginacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaCobrosType : RespuestaConsultaFacturaCobrosType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaCobros", Order=0)]
    public RegistroRespuestaConsultaCobrosType[] RegistroRespuestaConsultaCobros { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public double ClavePaginacion { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClavePaginacionSpecified { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLROperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRCobrosMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRDetOperIntracomunitariasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaConsultaLRFacturasEmitidasType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFacturasType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaConsultaLRFacturasTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public IndicadorPaginacionType IndicadorPaginacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ResultadoConsultaType ResultadoConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFacturasTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLROperacionesSegurosType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLROperacionesSeguros", Order=0)]
    public RegistroRespuestaConsultaOperacionesSegurosType[] RegistroRespuestaConsultaLROperacionesSeguros { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRAgenciasViajesType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRAgenciasViajes", Order=0)]
    public RegistroRespuestaConsultaAgenciasViajesType[] RegistroRespuestaConsultaLRAgenciasViajes { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRCobrosMetalicoType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRCobrosMetalico", Order=0)]
    public RegistroRespuestaConsultaCobrosMetalicoType[] RegistroRespuestaConsultaLRCobrosMetalico { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRDetOperIntracomunitariasType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRDetOperIntracomunitarias", Order=0)]
    public RegistroRespuestaConsultaDetOperIntracomunitariasType[] RegistroRespuestaConsultaLRDetOperIntracomunitarias { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRBienesInversionType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRBienesInversion", Order=0)]
    public RegistroRespuestaConsultaBienesType[] RegistroRespuestaConsultaLRBienesInversion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFacturasRecibidasType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRFacturasRecibidas", Order=0)]
    public RegistroRespuestaConsultaRecibidasType[] RegistroRespuestaConsultaLRFacturasRecibidas { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd")]
public class RespuestaConsultaLRFacturasEmitidasType : RespuestaConsultaLRFacturasType
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroRespuestaConsultaLRFacturasEmitidas", Order=0)]
    public RegistroRespuestaConsultaEmitidasType[] RegistroRespuestaConsultaLRFacturasEmitidas { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class ConsultaInmueblesAdicionalesType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroInmueblesAdicionalesType FiltroConsultaInmueblesAdicionales { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class ConsultaPagosType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroPagosType FiltroConsultaPagos { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class ConsultaCobrosType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroCobrosType FiltroConsultaCobros { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaLROperacionesSegurosType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroOperacionesSegurosType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroOperacionesSegurosType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ContraparteConsultaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveOperacionType ClaveOperacion { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClaveOperacionSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public FacturaModificadaType OperacionModificada { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool OperacionModificadaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public LRFiltroOperacionesSegurosTypeClavePaginacion ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ContraparteConsultaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=1)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=1)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RangoFechaPresentacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Desde { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Hasta { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum FacturaModificadaType
{
    S,
    N,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroOperacionesSegurosTypeClavePaginacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveOperacionType ClaveOperacion { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroCobrosMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroOperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroDetOperIntracomunitariasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroBienInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFiltroEmitidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaOperacionIntracomunitariaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LROperacionIntracomunitariaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaRegistroLROperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LROperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaCobrosMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRCobrosMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRFacturasRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRBajaExpedidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(LRfacturasEmitidasType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RegistroSiiPeriodoLiquidacion PeriodoLiquidacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RegistroSiiPeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroAgenciasViajesType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ContraparteConsultaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public FacturaModificadaType RegistroModificado { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RegistroModificadoSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public LRFiltroAgenciasViajesTypeClavePaginacion ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroAgenciasViajesTypeClavePaginacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroCobrosMetalicoType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ContraparteConsultaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public FacturaModificadaType CobroModificado { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CobroModificadoSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public LRFiltroCobrosMetalicoTypeClavePaginacion ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroCobrosMetalicoTypeClavePaginacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroDetOperIntracomunitariasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaConsulta1Type IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public FacturaModificadaType FacturaModificada { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaModificadaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public IDFacturaComunitariaType ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaConsulta1Type
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaConsulta1TypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaConsulta1TypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=1)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=1)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroBienInversionType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaConsulta1Type IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public FacturaModificadaType FacturaModificada { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaModificadaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string IdentificacionBien { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public ClavePaginacionBienType ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ClavePaginacionBienType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ClavePaginacionBienTypeIDEmisorFactura IDEmisorFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaExpedicionFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string IdentificacionBien { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class ClavePaginacionBienTypeIDEmisorFactura
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IDOtro", typeof(IDOtroType), Order=1)]
    [System.Xml.Serialization.XmlElementAttribute("NIF", typeof(string), Order=1)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroRecibidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaConsulta1Type IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public RangoFechaPresentacionType FechaCuadre { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public FacturaModificadaType FacturaModificada { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaModificadaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public EstadoCuadreType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public IDFacturaRecibidaNombreBCType ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRFiltroEmitidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaConsulta2Type IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ContraparteConsultaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public RangoFechaPresentacionType FechaPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public RangoFechaPresentacionType FechaCuadre { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public FacturaModificadaType FacturaModificada { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaModificadaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public EstadoCuadreType EstadoCuadre { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EstadoCuadreSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public IDFacturaExpedidaBCType ClavePaginacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class IDFacturaConsulta2Type
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NumSerieFacturaEmisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string FechaExpedicionFacturaEmisor { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaOperacionIntracomunitariaType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LROperacionIntracomunitariaType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public OperacionIntracomunitariaType OperacionIntracomunitaria { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaRegistroLROperacionesSegurosType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveOperacionType ClaveOperacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LROperacionesSegurosType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveOperacionType ClaveOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaCobrosMetalicoType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRCobrosMetalicoType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaAgenciasViajesType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRAgenciasViajesType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaBienesInversionType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string IdentificacionBien { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string RefExterna { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBienesInversionType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public BienDeInversionType BienesInversion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaRecibidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRFacturasRecibidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public FacturaRecibidaType FacturaRecibida { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class FacturaRecibidaType : FacturaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DesgloseFacturaRecibidasType DesgloseFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FechaRegContable { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string CuotaDeducible { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(FacturaRecibidaType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FacturaExpedidaType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class FacturaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ClaveTipoFacturaType TipoFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ClaveTipoRectificativaType TipoRectificativa { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoRectificativaSpecified { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("IDFacturaAgrupada", IsNullable=false)]
    public IDFacturaARType[] FacturasAgrupadas { get; set; }

    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("IDFacturaRectificada", IsNullable=false)]
    public IDFacturaARType[] FacturasRectificadas { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public DesgloseRectificacionType ImporteRectificacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string FechaOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenEspecialOTrascendencia { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenEspecialOTrascendenciaAdicional1 { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClaveRegimenEspecialOTrascendenciaAdicional1Specified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public IdOperacionesTrascendenciaTributariaType ClaveRegimenEspecialOTrascendenciaAdicional2 { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClaveRegimenEspecialOTrascendenciaAdicional2Specified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string NumRegistroAcuerdoFacturacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string ImporteTotal { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string BaseImponibleACoste { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public string DescripcionOperacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("FacturaSimplificadaArticulos7.2_7.3", Order=14)]
    public SimplificadaCualificadaType FacturaSimplificadaArticulos72_73 { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaSimplificadaArticulos72_73Specified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public PersonaFisicaJuridicaUnicaESType EntidadSucedida { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public RegPrevioGGEEoREDEMEoCompetenciaType RegPrevioGGEEoREDEMEoCompetencia { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RegPrevioGGEEoREDEMEoCompetenciaSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public MacrodatoType Macrodato { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MacrodatoSpecified { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class FacturaExpedidaType : FacturaType
{
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DetalleInmueble", IsNullable=false)]
    public DatosInmuebleType[] DatosInmueble { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string ImporteTransmisionInmueblesSujetoAIVA { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EmitidaPorTercerosType EmitidaPorTercerosODestinatario { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EmitidaPorTercerosODestinatarioSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EmitidaPorTercerosType FacturacionDispAdicionalTerceraYsextayDelMercadoOrganizadoDelGas { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturacionDispAdicionalTerceraYsextayDelMercadoOrganizadoDelGasSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public VariosDestinatariosType VariosDestinatarios { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VariosDestinatariosSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public CuponType Cupon { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CuponSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("FacturaSinIdentifDestinatarioAritculo6.1.d", Order=6)]
    public CompletaSinDestinatarioType FacturaSinIdentifDestinatarioAritculo61d { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FacturaSinIdentifDestinatarioAritculo61dSpecified { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public FacturaExpedidaTypeTipoDesglose TipoDesglose { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class FacturaExpedidaTypeTipoDesglose
{
    [System.Xml.Serialization.XmlElementAttribute("DesgloseFactura", typeof(TipoSinDesgloseType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("DesgloseTipoOperacion", typeof(TipoConDesgloseType), Order=0)]
    public object Item { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class LRBajaExpedidasType : RegistroSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaAgenciasViajesType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroAgenciasViajesType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaCobrosMetalicoType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroCobrosMetalicoType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaDetOperIntracomunitariasType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroDetOperIntracomunitariasType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaBienesInversionType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroBienInversionType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaEmitidasType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroEmitidasType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd")]
public class LRConsultaRecibidasType : ConsultaInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public LRFiltroRecibidasType FiltroConsulta { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaOperacionesSegurosBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaOperacionesSegurosBajaTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

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
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaOperacionesSegurosBajaTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public enum EstadoRegistroType
{
    Correcto,
    AceptadoConErrores,
    Incorrecto,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaAgenciasViajesBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaAgenciasViajesBajaTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaAgenciasViajesBajaTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaMetalicoBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaMetalicoBajaTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaMetalicoBajaTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaComunitariaBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaBienBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaBienBajaTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string IdentificacionBien { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=5)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaBienBajaTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaRecibidaBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaExpedidaBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaRecibidaPagoType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaNombreBCType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=2)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string DescripcionErrorRegistro { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaOperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaIMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaOComunitariasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaFRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaFEmitidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBajaFRecibidasPagosType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacionType DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public CabeceraSiiBaja Cabecera { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoEnvioType EstadoEnvio { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class DatosPresentacionType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NIFPresentador { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string TimestampPresentacion { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class CabeceraSiiBaja
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public VersionSiiType IDVersionSii { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaESType Titular { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class PersonaFisicaJuridicaESType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string NombreRazon { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NIFRepresentante { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string NIF { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public enum EstadoEnvioType
{
    Correcto,
    ParcialmenteCorrecto,
    Incorrecto,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaOperacionesSegurosType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaOperacionesSegurosBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaAgenciasViajesType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaAgenciasViajesBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaIMetalicoType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaMetalicoBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaOComunitariasType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaComunitariaBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaBienesInversionType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaBienBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaFRecibidasType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaRecibidaBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaFEmitidasType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaExpedidaBajaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBajaFRecibidasPagosType : RespuestaComunBajaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaRecibidaPagoType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class SuministroInformacionBaja
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public CabeceraSiiBaja Cabecera { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
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

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaOperacionesSegurosTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class RegistroDuplicadoType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EstadoRegistroSIIType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=1)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string DescripcionErrorRegistro { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum EstadoRegistroSIIType
{
    Correcta,
    AceptadaConErrores,
    Anulada,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaAgenciasViajesType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaAgenciasViajesTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public RegistroDuplicadoType RegistroDuplicado { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaAgenciasViajesTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaMetalicoType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaMetalicoTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaType Contraparte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public RegistroDuplicadoType RegistroDuplicado { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaMetalicoTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaComunitariaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public RegistroDuplicadoType RegistroDuplicado { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaBienType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RespuestaBienTypePeriodoLiquidacion PeriodoLiquidacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public IDFacturaComunitariaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string IdentificacionBien { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=5)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public RegistroDuplicadoType RegistroDuplicado { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaBienTypePeriodoLiquidacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Ejercicio { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TipoPeriodoType Periodo { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaRecibidaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaRecibidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public RegistroDuplicadoType RegistroDuplicado { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaExpedidaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public IDFacturaExpedidaType IDFactura { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RefExterna { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public EstadoRegistroType EstadoRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
    public string CodigoErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string DescripcionErrorRegistro { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public RegistroDuplicadoType RegistroDuplicado { get; set; }
}

[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLROperacionesSegurosType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRAgenciasViajesType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRIMetalicoType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLROComunitariasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRBienesInversionType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRFRecibidasType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(RespuestaLRFEmitidasType))][System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string CSV { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public DatosPresentacionType DatosPresentacion { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public CabeceraSii Cabecera { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EstadoEnvioType EstadoEnvio { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class CabeceraSii
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public VersionSiiType IDVersionSii { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PersonaFisicaJuridicaESType Titular { get; set; }

    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ClaveTipoComunicacionType TipoComunicacion { get; set; }
}

[System.SerializableAttribute]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public enum ClaveTipoComunicacionType
{
    A0,
    A1,
    A4,
    A5,
    A6,
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLROperacionesSegurosType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaOperacionesSegurosType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRAgenciasViajesType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaAgenciasViajesType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRIMetalicoType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaMetalicoType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLROComunitariasType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaComunitariaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRBienesInversionType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaBienType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRFRecibidasType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaRecibidaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd")]
public class RespuestaLRFEmitidasType : RespuestaComunAltaType
{
    [System.Xml.Serialization.XmlElementAttribute("RespuestaLinea", Order=0)]
    public RespuestaExpedidaType[] RespuestaLinea { get; set; }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroInformacion.xsd")]
public class SuministroInformacion
{
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public CabeceraSii Cabecera { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class SuministroLRFacturasEmitidasRequest
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd", Order=0)]
    public SuministroLRFacturasEmitidas SuministroLRFacturasEmitidas;
    
    public SuministroLRFacturasEmitidasRequest()
    {
    }
    
    public SuministroLRFacturasEmitidasRequest(SuministroLRFacturasEmitidas SuministroLRFacturasEmitidas)
    {
        this.SuministroLRFacturasEmitidas = SuministroLRFacturasEmitidas;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class SuministroLRFacturasEmitidasResponse
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd", Order=0)]
    public RespuestaLRFEmitidasType RespuestaLRFacturasEmitidas;
    
    public SuministroLRFacturasEmitidasResponse()
    {
    }
    
    public SuministroLRFacturasEmitidasResponse(RespuestaLRFEmitidasType RespuestaLRFacturasEmitidas)
    {
        this.RespuestaLRFacturasEmitidas = RespuestaLRFacturasEmitidas;
    }
}

[System.SerializableAttribute][System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
public class BajaLRFacturasEmitidas : SuministroInformacionBaja
{
    [System.Xml.Serialization.XmlElementAttribute("RegistroLRBajaExpedidas", Order=0)]
    public LRBajaExpedidasType[] RegistroLRBajaExpedidas { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class AnulacionLRFacturasEmitidasRequest
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd", Order=0)]
    public BajaLRFacturasEmitidas BajaLRFacturasEmitidas;
    
    public AnulacionLRFacturasEmitidasRequest()
    {
    }
    
    public AnulacionLRFacturasEmitidasRequest(BajaLRFacturasEmitidas BajaLRFacturasEmitidas)
    {
        this.BajaLRFacturasEmitidas = BajaLRFacturasEmitidas;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class AnulacionLRFacturasEmitidasResponse
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaSuministro.xsd", Order=0)]
    public RespuestaLRBajaFEmitidasType RespuestaLRBajaFacturasEmitidas;
    
    public AnulacionLRFacturasEmitidasResponse()
    {
    }
    
    public AnulacionLRFacturasEmitidasResponse(RespuestaLRBajaFEmitidasType RespuestaLRBajaFacturasEmitidas)
    {
        this.RespuestaLRBajaFacturasEmitidas = RespuestaLRBajaFacturasEmitidas;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class ConsultaLRFacturasEmitidasRequest
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd", Order=0)]
    public LRConsultaEmitidasType ConsultaLRFacturasEmitidas;
    
    public ConsultaLRFacturasEmitidasRequest()
    {
    }
    
    public ConsultaLRFacturasEmitidasRequest(LRConsultaEmitidasType ConsultaLRFacturasEmitidas)
    {
        this.ConsultaLRFacturasEmitidas = ConsultaLRFacturasEmitidas;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class ConsultaLRFacturasEmitidasResponse
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd", Order=0)]
    public RespuestaConsultaLRFacturasEmitidasType RespuestaConsultaLRFacturasEmitidas;
    
    public ConsultaLRFacturasEmitidasResponse()
    {
    }
    
    public ConsultaLRFacturasEmitidasResponse(RespuestaConsultaLRFacturasEmitidasType RespuestaConsultaLRFacturasEmitidas)
    {
        this.RespuestaConsultaLRFacturasEmitidas = RespuestaConsultaLRFacturasEmitidas;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class ConsultaLRFactInformadasClienteRequest
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd", Order=0)]
    public ConsultaLRFactInformadasClienteType ConsultaLRFactInformadasCliente;
    
    public ConsultaLRFactInformadasClienteRequest()
    {
    }
    
    public ConsultaLRFactInformadasClienteRequest(ConsultaLRFactInformadasClienteType ConsultaLRFactInformadasCliente)
    {
        this.ConsultaLRFactInformadasCliente = ConsultaLRFactInformadasCliente;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class ConsultaLRFactInformadasClienteResponse
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd", Order=0)]
    public RespuestaConsultaLRFactInformadasClienteType RespuestaConsultaLRFactInformadasCliente;
    
    public ConsultaLRFactInformadasClienteResponse()
    {
    }
    
    public ConsultaLRFactInformadasClienteResponse(RespuestaConsultaLRFactInformadasClienteType RespuestaConsultaLRFactInformadasCliente)
    {
        this.RespuestaConsultaLRFactInformadasCliente = RespuestaConsultaLRFactInformadasCliente;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class ConsultaLRFactInformadasAgrupadasClienteRequest
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/ConsultaLR.xsd", Order=0)]
    public ConsultaLRFactInformadasAgrupadasClienteType ConsultaLRFactInformadasAgrupadasCliente;
    
    public ConsultaLRFactInformadasAgrupadasClienteRequest()
    {
    }
    
    public ConsultaLRFactInformadasAgrupadasClienteRequest(ConsultaLRFactInformadasAgrupadasClienteType ConsultaLRFactInformadasAgrupadasCliente)
    {
        this.ConsultaLRFactInformadasAgrupadasCliente = ConsultaLRFactInformadasAgrupadasCliente;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public class ConsultaLRFactInformadasAgrupadasClienteResponse
{
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/RespuestaConsultaLR.xsd", Order=0)]
    public RespuestaConsultaLRFactInformadasAgrupadasClienteType RespuestaConsultaLRFactInformadasAgrupadasCliente;
    
    public ConsultaLRFactInformadasAgrupadasClienteResponse()
    {
    }
    
    public ConsultaLRFactInformadasAgrupadasClienteResponse(RespuestaConsultaLRFactInformadasAgrupadasClienteType RespuestaConsultaLRFactInformadasAgrupadasCliente)
    {
        this.RespuestaConsultaLRFactInformadasAgrupadasCliente = RespuestaConsultaLRFactInformadasAgrupadasCliente;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface siiSOAPChannel : siiSOAP, System.ServiceModel.IClientChannel
{
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public class siiSOAPClient : System.ServiceModel.ClientBase<siiSOAP>, siiSOAP
{
    public siiSOAPClient()
    {
    }
    
    public siiSOAPClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public siiSOAPClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public siiSOAPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public siiSOAPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    SuministroLRFacturasEmitidasResponse siiSOAP.SuministroLRFacturasEmitidas(SuministroLRFacturasEmitidasRequest request)
    {
        return base.Channel.SuministroLRFacturasEmitidas(request);
    }
    
    public RespuestaLRFEmitidasType SuministroLRFacturasEmitidas(SuministroLRFacturasEmitidas SuministroLRFacturasEmitidas1)
    {
        SuministroLRFacturasEmitidasRequest inValue = new SuministroLRFacturasEmitidasRequest();
        inValue.SuministroLRFacturasEmitidas = SuministroLRFacturasEmitidas1;
        SuministroLRFacturasEmitidasResponse retVal = ((siiSOAP)(this)).SuministroLRFacturasEmitidas(inValue);
        return retVal.RespuestaLRFacturasEmitidas;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SuministroLRFacturasEmitidasResponse> siiSOAP.SuministroLRFacturasEmitidasAsync(SuministroLRFacturasEmitidasRequest request)
    {
        return base.Channel.SuministroLRFacturasEmitidasAsync(request);
    }
    
    public System.Threading.Tasks.Task<SuministroLRFacturasEmitidasResponse> SuministroLRFacturasEmitidasAsync(SuministroLRFacturasEmitidas SuministroLRFacturasEmitidas)
    {
        SuministroLRFacturasEmitidasRequest inValue = new SuministroLRFacturasEmitidasRequest();
        inValue.SuministroLRFacturasEmitidas = SuministroLRFacturasEmitidas;
        return ((siiSOAP)(this)).SuministroLRFacturasEmitidasAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    AnulacionLRFacturasEmitidasResponse siiSOAP.AnulacionLRFacturasEmitidas(AnulacionLRFacturasEmitidasRequest request)
    {
        return base.Channel.AnulacionLRFacturasEmitidas(request);
    }
    
    public RespuestaLRBajaFEmitidasType AnulacionLRFacturasEmitidas(BajaLRFacturasEmitidas BajaLRFacturasEmitidas)
    {
        AnulacionLRFacturasEmitidasRequest inValue = new AnulacionLRFacturasEmitidasRequest();
        inValue.BajaLRFacturasEmitidas = BajaLRFacturasEmitidas;
        AnulacionLRFacturasEmitidasResponse retVal = ((siiSOAP)(this)).AnulacionLRFacturasEmitidas(inValue);
        return retVal.RespuestaLRBajaFacturasEmitidas;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<AnulacionLRFacturasEmitidasResponse> siiSOAP.AnulacionLRFacturasEmitidasAsync(AnulacionLRFacturasEmitidasRequest request)
    {
        return base.Channel.AnulacionLRFacturasEmitidasAsync(request);
    }
    
    public System.Threading.Tasks.Task<AnulacionLRFacturasEmitidasResponse> AnulacionLRFacturasEmitidasAsync(BajaLRFacturasEmitidas BajaLRFacturasEmitidas)
    {
        AnulacionLRFacturasEmitidasRequest inValue = new AnulacionLRFacturasEmitidasRequest();
        inValue.BajaLRFacturasEmitidas = BajaLRFacturasEmitidas;
        return ((siiSOAP)(this)).AnulacionLRFacturasEmitidasAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaLRFacturasEmitidasResponse siiSOAP.ConsultaLRFacturasEmitidas(ConsultaLRFacturasEmitidasRequest request)
    {
        return base.Channel.ConsultaLRFacturasEmitidas(request);
    }
    
    public RespuestaConsultaLRFacturasEmitidasType ConsultaLRFacturasEmitidas(LRConsultaEmitidasType ConsultaLRFacturasEmitidas1)
    {
        ConsultaLRFacturasEmitidasRequest inValue = new ConsultaLRFacturasEmitidasRequest();
        inValue.ConsultaLRFacturasEmitidas = ConsultaLRFacturasEmitidas1;
        ConsultaLRFacturasEmitidasResponse retVal = ((siiSOAP)(this)).ConsultaLRFacturasEmitidas(inValue);
        return retVal.RespuestaConsultaLRFacturasEmitidas;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ConsultaLRFacturasEmitidasResponse> siiSOAP.ConsultaLRFacturasEmitidasAsync(ConsultaLRFacturasEmitidasRequest request)
    {
        return base.Channel.ConsultaLRFacturasEmitidasAsync(request);
    }
    
    public System.Threading.Tasks.Task<ConsultaLRFacturasEmitidasResponse> ConsultaLRFacturasEmitidasAsync(LRConsultaEmitidasType ConsultaLRFacturasEmitidas)
    {
        ConsultaLRFacturasEmitidasRequest inValue = new ConsultaLRFacturasEmitidasRequest();
        inValue.ConsultaLRFacturasEmitidas = ConsultaLRFacturasEmitidas;
        return ((siiSOAP)(this)).ConsultaLRFacturasEmitidasAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaLRFactInformadasClienteResponse siiSOAP.ConsultaLRFactInformadasCliente(ConsultaLRFactInformadasClienteRequest request)
    {
        return base.Channel.ConsultaLRFactInformadasCliente(request);
    }
    
    public RespuestaConsultaLRFactInformadasClienteType ConsultaLRFactInformadasCliente(ConsultaLRFactInformadasClienteType ConsultaLRFactInformadasCliente1)
    {
        ConsultaLRFactInformadasClienteRequest inValue = new ConsultaLRFactInformadasClienteRequest();
        inValue.ConsultaLRFactInformadasCliente = ConsultaLRFactInformadasCliente1;
        ConsultaLRFactInformadasClienteResponse retVal = ((siiSOAP)(this)).ConsultaLRFactInformadasCliente(inValue);
        return retVal.RespuestaConsultaLRFactInformadasCliente;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ConsultaLRFactInformadasClienteResponse> siiSOAP.ConsultaLRFactInformadasClienteAsync(ConsultaLRFactInformadasClienteRequest request)
    {
        return base.Channel.ConsultaLRFactInformadasClienteAsync(request);
    }
    
    public System.Threading.Tasks.Task<ConsultaLRFactInformadasClienteResponse> ConsultaLRFactInformadasClienteAsync(ConsultaLRFactInformadasClienteType ConsultaLRFactInformadasCliente)
    {
        ConsultaLRFactInformadasClienteRequest inValue = new ConsultaLRFactInformadasClienteRequest();
        inValue.ConsultaLRFactInformadasCliente = ConsultaLRFactInformadasCliente;
        return ((siiSOAP)(this)).ConsultaLRFactInformadasClienteAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaLRFactInformadasAgrupadasClienteResponse siiSOAP.ConsultaLRFactInformadasAgrupadasCliente(ConsultaLRFactInformadasAgrupadasClienteRequest request)
    {
        return base.Channel.ConsultaLRFactInformadasAgrupadasCliente(request);
    }
    
    public RespuestaConsultaLRFactInformadasAgrupadasClienteType ConsultaLRFactInformadasAgrupadasCliente(ConsultaLRFactInformadasAgrupadasClienteType ConsultaLRFactInformadasAgrupadasCliente1)
    {
        ConsultaLRFactInformadasAgrupadasClienteRequest inValue = new ConsultaLRFactInformadasAgrupadasClienteRequest();
        inValue.ConsultaLRFactInformadasAgrupadasCliente = ConsultaLRFactInformadasAgrupadasCliente1;
        ConsultaLRFactInformadasAgrupadasClienteResponse retVal = ((siiSOAP)(this)).ConsultaLRFactInformadasAgrupadasCliente(inValue);
        return retVal.RespuestaConsultaLRFactInformadasAgrupadasCliente;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ConsultaLRFactInformadasAgrupadasClienteResponse> siiSOAP.ConsultaLRFactInformadasAgrupadasClienteAsync(ConsultaLRFactInformadasAgrupadasClienteRequest request)
    {
        return base.Channel.ConsultaLRFactInformadasAgrupadasClienteAsync(request);
    }
    
    public System.Threading.Tasks.Task<ConsultaLRFactInformadasAgrupadasClienteResponse> ConsultaLRFactInformadasAgrupadasClienteAsync(ConsultaLRFactInformadasAgrupadasClienteType ConsultaLRFactInformadasAgrupadasCliente)
    {
        ConsultaLRFactInformadasAgrupadasClienteRequest inValue = new ConsultaLRFactInformadasAgrupadasClienteRequest();
        inValue.ConsultaLRFactInformadasAgrupadasCliente = ConsultaLRFactInformadasAgrupadasCliente;
        return ((siiSOAP)(this)).ConsultaLRFactInformadasAgrupadasClienteAsync(inValue);
    }
}
