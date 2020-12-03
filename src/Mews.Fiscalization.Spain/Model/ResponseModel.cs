using FuncSharp;
using System;

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

        public Header Header { get; }

        public RegisterResult Result { get; }

        public InvoiceResult[] Invoices { get; }

        public IOption<string> SuccessfulRequestId { get; }
    }

    public class InvoiceIdResponse
    {
        public InvoiceIdResponse(string issuer, string number, DateTime date)
        {
            Issuer = issuer;
            Number = number;
            Date = date;
        }

        public string Issuer { get; }

        public string Number { get; }

        public DateTime Date { get; }
    }

    public class InvoiceResult
    {
        public InvoiceResult(
            InvoiceIdResponse id,
            InvoiceRegisterResult result,
            int? errorCode = null,
            string errorMessage = null,
            string secureVerificationCodeForOriginalInvoice = null)
        {
            Id = id;
            Result = result;
            ErrorCode = errorCode.ToOption();
            ErrorMessage = errorMessage.ToOption();
            OriginalInvoiceRequestId = secureVerificationCodeForOriginalInvoice.ToOption();
        }

        public InvoiceIdResponse Id { get; }

        public InvoiceRegisterResult Result { get; }

        public IOption<int> ErrorCode { get; }

        public IOption<string> ErrorMessage { get; }

        public IOption<string> OriginalInvoiceRequestId { get; }
    }
}
