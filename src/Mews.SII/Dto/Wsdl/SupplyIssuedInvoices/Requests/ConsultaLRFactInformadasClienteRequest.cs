﻿using Mews.Sii.Dto.XSD.ConsultaLR;

namespace Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Requests
{
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
}