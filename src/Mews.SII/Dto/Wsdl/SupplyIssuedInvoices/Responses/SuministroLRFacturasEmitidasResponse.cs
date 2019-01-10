﻿using Mews.Sii.Dto.XSD.RespuestaSuministro;

namespace Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Responses
{
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

        public SuministroLRFacturasEmitidasResponse(RespuestaLRFEmitidasType respuestaLRFacturasEmitidas)
        {
            RespuestaLRFacturasEmitidas = respuestaLRFacturasEmitidas;
        }
    }
}