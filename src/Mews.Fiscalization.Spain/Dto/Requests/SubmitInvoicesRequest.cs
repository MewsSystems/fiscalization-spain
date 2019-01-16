using System.Xml.Serialization;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;

namespace Mews.Fiscalization.Spain.Dto.Requests
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    public class SubmitInvoicesRequest
    {
        public SubmitInvoicesRequest()
        {
        }

        public SubmitInvoicesRequest(SuministroLRFacturasEmitidas invoices)
        {
            Invoices = invoices;
        }

        [XmlElement(ElementName = "SuministroLRFacturasEmitidas", Namespace = "https://www2.agenciatributaria.gob.es/static_files/common/internet/dep/aplicaciones/es/aeat/ssii/fact/ws/SuministroLR.xsd")]
        public SuministroLRFacturasEmitidas Invoices { get; }
    }
}