using System;
using System.Globalization;
using System.Linq;
using FuncSharp;
using Mews.Fiscalization.Spain.Dto.Responses;
using Mews.Fiscalization.Spain.Dto.XSD.RespuestaSuministro;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain.Converters
{
    internal class DtoToModelConverter
    {
        public ReceivedInvoices Convert(SubmitInvoicesResponse response)
        {
            return new ReceivedInvoices(
                Convert(response.Cabecera),
                Convert(response.EstadoEnvio),
                response.RespuestaLinea.Select(i => Convert(i)).ToArray(),
                response.CSV.ToNonEmptyOption().GetOrNull());
        }

        private InvoiceResult Convert(RespuestaExpedidaType invoice)
        {
            var result = Convert(invoice.EstadoRegistro);
            return new InvoiceResult(
                Convert(invoice.IDFactura),
                result,
                invoice.CodigoErrorRegistro.ToInt().Match(c => (int?)c, _ => null),
                invoice.DescripcionErrorRegistro.ToNonEmptyOption().GetOrNull(),
                invoice.CSV.ToNonEmptyOption().GetOrNull()
            );
        }

        private InvoiceId Convert(IDFacturaExpedidaType iDFactura)
        {
            return new InvoiceId(
                new TaxPayerNumber(iDFactura.IDEmisorFactura.NIF),
                new LimitedString1to60(iDFactura.NumSerieFacturaEmisor), ConvertDate(iDFactura.FechaExpedicionFacturaEmisor)
            );
        }

        private Header Convert(CabeceraSii cabecera)
        {
            return new Header(
                new CompanyTitle(new LimitedString120(cabecera.Titular.NombreRazon), new TaxPayerNumber(cabecera.Titular.NIF)),
                cabecera.TipoComunicacion.Match(
                    ClaveTipoComunicacionType.A0, _ => CommunicationType.Registration,
                    ClaveTipoComunicacionType.A1, _ => CommunicationType.Amendment,
                    ClaveTipoComunicacionType.A4, _ => CommunicationType.AmendmentForTravellers
                )
            );
        }

        private RegisterResult Convert(EstadoEnvioType estadoEnvio)
        {
            return estadoEnvio.Match(
                EstadoEnvioType.Correcto, _ => RegisterResult.Correct,
                EstadoEnvioType.ParcialmenteCorrecto, _ => RegisterResult.PartialyIncorrect,
                EstadoEnvioType.Incorrecto, _ => RegisterResult.AllIncorrect
            );
        }

        private InvoiceRegisterResult Convert(EstadoRegistroType estadoRegistro)
        {
            return estadoRegistro.Match(
                EstadoRegistroType.Correcto, _ => InvoiceRegisterResult.Accepted,
                EstadoRegistroType.AceptadoConErrores, _ => InvoiceRegisterResult.AcceptedWithErrors,
                EstadoRegistroType.Incorrecto, _ => InvoiceRegisterResult.Rejected
            );
        }

        private DateTime ConvertDate(string date)
        {
            return DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
    }
}
