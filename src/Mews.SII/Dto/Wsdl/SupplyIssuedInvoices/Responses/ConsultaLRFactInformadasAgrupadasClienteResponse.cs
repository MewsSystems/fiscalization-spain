﻿using Mews.Sii.Dto.XSD.RespuestaConsultaLR;

namespace Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Responses
{
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
}