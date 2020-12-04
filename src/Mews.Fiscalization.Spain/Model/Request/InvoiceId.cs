using Mews.Fiscalization.Core.Model;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class InvoiceId
    {
        public InvoiceId(TaxpayerIdentificationNumber issuer, LimitedString1to60 number, DateTime date)
        {
            Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
            Number = number ?? throw new ArgumentNullException(nameof(number));
            Date = date;
        }

        public TaxpayerIdentificationNumber Issuer { get; }

        public LimitedString1to60 Number { get; }

        public DateTime Date { get; }
    }
}
