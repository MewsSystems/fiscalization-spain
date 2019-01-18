using FuncSharp;

namespace Mews.Fiscalization.Spain.Model
{
    public class ReceivedInvoices
    {
        public ReceivedInvoices(Header header, RegisterResult result, InvoiceResult[] invoices, string secureVerificationCode = null)
        {
            Header = header;
            Result = result;
            Invoices = invoices;
            SuccessfulRequestId = secureVerificationCode.ToOption();
        }

        /// <summary>
        /// Cabecera
        /// </summary>
        public Header Header { get; }

        /// <summary>
        /// EstadoEnvio
        /// </summary>
        public RegisterResult Result { get; }

        /// <summary>
        /// RespuestaLinea
        /// </summary>
        public InvoiceResult[] Invoices { get; }

        /// <summary>
        /// CSV
        /// </summary>
        public IOption<string> SuccessfulRequestId { get; }
    }

    public class InvoiceResult
    {
        public InvoiceResult(InvoiceId id, InvoiceRegisterResult result, int? errorCode = null, string errorMessage = null, string secureVerificationCodeForOriginalInvoice = null)
        {
            Id = id;
            Result = result;
            ErrorCode = errorCode.ToOption();
            ErrorMessage = errorMessage.ToOption();
            OriginalInvoiceRequestId = secureVerificationCodeForOriginalInvoice.ToOption();
        }

        /// <summary>
        /// IDFactura
        /// </summary>
        public InvoiceId Id { get; }

        /// <summary>
        /// EstadoRegistro
        /// </summary>
        public InvoiceRegisterResult Result { get; }

        /// <summary>
        /// CodigoErrorRegistro
        /// </summary>
        public IOption<int> ErrorCode { get; }

        /// <summary>
        /// DescripcionErrorRegistro
        /// </summary>
        public IOption<string> ErrorMessage { get; }

        /// <summary>
        /// CSV
        /// </summary>
        public IOption<string> OriginalInvoiceRequestId { get; }
    }
}
