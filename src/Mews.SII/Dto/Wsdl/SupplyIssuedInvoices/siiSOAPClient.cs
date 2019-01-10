using Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Requests;
using Mews.Sii.Dto.Wsdl.SupplyIssuedInvoices.Responses;
using Mews.Sii.Dto.XSD.ConsultaLR;
using Mews.Sii.Dto.XSD.RespuestaConsultaLR;
using Mews.Sii.Dto.XSD.RespuestaSuministro;
using Mews.Sii.Dto.XSD.SuministroInformacion;
using Mews.Sii.Dto.XSD.SuministroLR;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public class SiiSoapClient : System.ServiceModel.ClientBase<ISiiSOAPClient>, ISiiSOAPClient
{
    public SiiSoapClient()
    {
    }

    public SiiSoapClient(string endpointConfigurationName)
        : base(endpointConfigurationName)
    {
    }

    public SiiSoapClient(string endpointConfigurationName, string remoteAddress)
        : base(endpointConfigurationName, remoteAddress)
    {
    }

    public SiiSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
        : base(endpointConfigurationName, remoteAddress)
    {
    }

    public SiiSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
        : base(binding, remoteAddress)
    {
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    SuministroLRFacturasEmitidasResponse ISiiSOAPClient.SuministroLRFacturasEmitidas(SuministroLRFacturasEmitidasRequest request)
    {
        return Channel.SuministroLRFacturasEmitidas(request);
    }

    public RespuestaLRFEmitidasType SuministroLRFacturasEmitidas(SuministroLRFacturasEmitidas suministroLRFacturasEmitidas1)
    {
        SuministroLRFacturasEmitidasRequest inValue = new SuministroLRFacturasEmitidasRequest();
        inValue.SuministroLRFacturasEmitidas = suministroLRFacturasEmitidas1;
        SuministroLRFacturasEmitidasResponse retVal = ((ISiiSOAPClient)this).SuministroLRFacturasEmitidas(inValue);
        return retVal.RespuestaLRFacturasEmitidas;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SuministroLRFacturasEmitidasResponse> ISiiSOAPClient.SuministroLRFacturasEmitidasAsync(SuministroLRFacturasEmitidasRequest request)
    {
        return Channel.SuministroLRFacturasEmitidasAsync(request);
    }

    public System.Threading.Tasks.Task<SuministroLRFacturasEmitidasResponse> SuministroLRFacturasEmitidasAsync(SuministroLRFacturasEmitidas suministroLRFacturasEmitidas)
    {
        SuministroLRFacturasEmitidasRequest inValue = new SuministroLRFacturasEmitidasRequest();
        inValue.SuministroLRFacturasEmitidas = suministroLRFacturasEmitidas;
        return ((ISiiSOAPClient)this).SuministroLRFacturasEmitidasAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    AnulacionLRFacturasEmitidasResponse ISiiSOAPClient.AnulacionLRFacturasEmitidas(AnulacionLRFacturasEmitidasRequest request)
    {
        return Channel.AnulacionLRFacturasEmitidas(request);
    }

    public RespuestaLRBajaFEmitidasType AnulacionLRFacturasEmitidas(BajaLRFacturasEmitidas bajaLRFacturasEmitidas)
    {
        AnulacionLRFacturasEmitidasResponse response = ((ISiiSOAPClient)this).AnulacionLRFacturasEmitidas(new AnulacionLRFacturasEmitidasRequest
        {
            BajaLRFacturasEmitidas = bajaLRFacturasEmitidas
        });

        return response.RespuestaLRBajaFacturasEmitidas;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<AnulacionLRFacturasEmitidasResponse> ISiiSOAPClient.AnulacionLRFacturasEmitidasAsync(AnulacionLRFacturasEmitidasRequest request)
    {
        return Channel.AnulacionLRFacturasEmitidasAsync(request);
    }

    public System.Threading.Tasks.Task<AnulacionLRFacturasEmitidasResponse> AnulacionLRFacturasEmitidasAsync(BajaLRFacturasEmitidas bajaLRFacturasEmitidas)
    {
        AnulacionLRFacturasEmitidasRequest inValue = new AnulacionLRFacturasEmitidasRequest();
        inValue.BajaLRFacturasEmitidas = bajaLRFacturasEmitidas;
        return ((ISiiSOAPClient)this).AnulacionLRFacturasEmitidasAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaLRFacturasEmitidasResponse ISiiSOAPClient.ConsultaLRFacturasEmitidas(ConsultaLRFacturasEmitidasRequest request)
    {
        return Channel.ConsultaLRFacturasEmitidas(request);
    }

    public RespuestaConsultaLRFacturasEmitidasType ConsultaLRFacturasEmitidas(LRConsultaEmitidasType consultaLRFacturasEmitidas1)
    {
        ConsultaLRFacturasEmitidasRequest inValue = new ConsultaLRFacturasEmitidasRequest();
        inValue.ConsultaLRFacturasEmitidas = consultaLRFacturasEmitidas1;
        ConsultaLRFacturasEmitidasResponse retVal = ((ISiiSOAPClient)this).ConsultaLRFacturasEmitidas(inValue);
        return retVal.RespuestaConsultaLRFacturasEmitidas;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ConsultaLRFacturasEmitidasResponse> ISiiSOAPClient.ConsultaLRFacturasEmitidasAsync(ConsultaLRFacturasEmitidasRequest request)
    {
        return Channel.ConsultaLRFacturasEmitidasAsync(request);
    }

    public System.Threading.Tasks.Task<ConsultaLRFacturasEmitidasResponse> ConsultaLRFacturasEmitidasAsync(LRConsultaEmitidasType consultaLRFacturasEmitidas)
    {
        ConsultaLRFacturasEmitidasRequest inValue = new ConsultaLRFacturasEmitidasRequest();
        inValue.ConsultaLRFacturasEmitidas = consultaLRFacturasEmitidas;
        return ((ISiiSOAPClient)this).ConsultaLRFacturasEmitidasAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaLRFactInformadasClienteResponse ISiiSOAPClient.ConsultaLRFactInformadasCliente(ConsultaLRFactInformadasClienteRequest request)
    {
        return Channel.ConsultaLRFactInformadasCliente(request);
    }

    public RespuestaConsultaLRFactInformadasClienteType ConsultaLRFactInformadasCliente(ConsultaLRFactInformadasClienteType consultaLRFactInformadasCliente1)
    {
        ConsultaLRFactInformadasClienteRequest inValue = new ConsultaLRFactInformadasClienteRequest();
        inValue.ConsultaLRFactInformadasCliente = consultaLRFactInformadasCliente1;
        ConsultaLRFactInformadasClienteResponse retVal = ((ISiiSOAPClient)this).ConsultaLRFactInformadasCliente(inValue);
        return retVal.RespuestaConsultaLRFactInformadasCliente;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ConsultaLRFactInformadasClienteResponse> ISiiSOAPClient.ConsultaLRFactInformadasClienteAsync(ConsultaLRFactInformadasClienteRequest request)
    {
        return Channel.ConsultaLRFactInformadasClienteAsync(request);
    }

    public System.Threading.Tasks.Task<ConsultaLRFactInformadasClienteResponse> ConsultaLRFactInformadasClienteAsync(ConsultaLRFactInformadasClienteType consultaLRFactInformadasCliente)
    {
        ConsultaLRFactInformadasClienteRequest inValue = new ConsultaLRFactInformadasClienteRequest();
        inValue.ConsultaLRFactInformadasCliente = consultaLRFactInformadasCliente;
        return ((ISiiSOAPClient)this).ConsultaLRFactInformadasClienteAsync(inValue);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaLRFactInformadasAgrupadasClienteResponse ISiiSOAPClient.ConsultaLRFactInformadasAgrupadasCliente(ConsultaLRFactInformadasAgrupadasClienteRequest request)
    {
        return Channel.ConsultaLRFactInformadasAgrupadasCliente(request);
    }

    public RespuestaConsultaLRFactInformadasAgrupadasClienteType ConsultaLRFactInformadasAgrupadasCliente(ConsultaLRFactInformadasAgrupadasClienteType consultaLRFactInformadasAgrupadasCliente1)
    {
        ConsultaLRFactInformadasAgrupadasClienteRequest inValue = new ConsultaLRFactInformadasAgrupadasClienteRequest();
        inValue.ConsultaLRFactInformadasAgrupadasCliente = consultaLRFactInformadasAgrupadasCliente1;
        ConsultaLRFactInformadasAgrupadasClienteResponse retVal = ((ISiiSOAPClient)this).ConsultaLRFactInformadasAgrupadasCliente(inValue);
        return retVal.RespuestaConsultaLRFactInformadasAgrupadasCliente;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<ConsultaLRFactInformadasAgrupadasClienteResponse> ISiiSOAPClient.ConsultaLRFactInformadasAgrupadasClienteAsync(ConsultaLRFactInformadasAgrupadasClienteRequest request)
    {
        return Channel.ConsultaLRFactInformadasAgrupadasClienteAsync(request);
    }

    public System.Threading.Tasks.Task<ConsultaLRFactInformadasAgrupadasClienteResponse> ConsultaLRFactInformadasAgrupadasClienteAsync(ConsultaLRFactInformadasAgrupadasClienteType consultaLRFactInformadasAgrupadasCliente)
    {
        ConsultaLRFactInformadasAgrupadasClienteRequest inValue = new ConsultaLRFactInformadasAgrupadasClienteRequest();
        inValue.ConsultaLRFactInformadasAgrupadasCliente = consultaLRFactInformadasAgrupadasCliente;
        return ((ISiiSOAPClient)this).ConsultaLRFactInformadasAgrupadasClienteAsync(inValue);
    }
}