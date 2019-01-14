﻿using Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Requests;
using Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Responses;
using Mews.Sii.Dto.XSD.RespuestaConsultaLR;
using Mews.Sii.Dto.XSD.RespuestaSuministro;
using Mews.Sii.Dto.XSD.SuministroInformacion;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroFactEmitidas.wsdl", ConfigurationName="siiSOAP")]
public interface ISiiSOAPClient
{
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute]
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
    [System.ServiceModel.XmlSerializerFormatAttribute]
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
    [System.ServiceModel.XmlSerializerFormatAttribute]
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
    [System.ServiceModel.XmlSerializerFormatAttribute]
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
    [System.ServiceModel.XmlSerializerFormatAttribute]
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
}