using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class AddedInvoice : Invoice
    {
        public AddedInvoice(
            TaxPeriod taxPeriod,
            InvoiceId id,
            InvoiceType type,
            SchemeOrEffect schemeOrEffect,
            Amount totalAmount,
            LimitedString500 description,
            BreakdownItem breakdown,
            CounterPartyCompany counterParty = null)
            : base(taxPeriod, id)
        {
            if (counterParty == null && type != InvoiceType.SimplifiedInvoice)
            {
                throw new Exception($"{nameof(counterParty)} has to be specified if 'SimplifiedInvoice' is not used.");
            }

            Type = type;
            SchemeOrEffect = schemeOrEffect;
            TotalAmount = totalAmount ?? throw new ArgumentNullException(nameof(totalAmount));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CounterParty = counterParty;
            Breakdown = breakdown ?? throw new ArgumentNullException(nameof(breakdown));
        }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public Amount TotalAmount { get; }

        public LimitedString500 Description { get; }

        public CounterPartyCompany CounterParty { get; }

        public BreakdownItem Breakdown { get; }
    }
}
