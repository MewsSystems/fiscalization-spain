﻿using Mews.Fiscalization.Spain.Dto.XSD.RespuestaSuministro;

namespace Mews.Fiscalization.Spain.Dto.Wsdl.SupplyIssuedInvoices.Responses
{
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

        public AnulacionLRFacturasEmitidasResponse(RespuestaLRBajaFEmitidasType respuestaLRBajaFacturasEmitidas)
        {
            RespuestaLRBajaFacturasEmitidas = respuestaLRBajaFacturasEmitidas;
        }
    }
}