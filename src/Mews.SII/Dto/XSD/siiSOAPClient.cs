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