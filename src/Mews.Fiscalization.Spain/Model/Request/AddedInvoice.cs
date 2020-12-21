using FuncSharp;
using System;
using System.Linq;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class AddedInvoice : Invoice
    {
        public AddedInvoice(
            TaxPeriod taxPeriod,
            InvoiceId id,
            InvoiceType type,
            SchemeOrEffect schemeOrEffect,
            LimitedString500 description,
            TaxBreakdown taxBreakdown,
            bool issuedByThirdParty,
            CounterPartyCompany counterParty = null)
            : base(taxPeriod, id)
        {
            if (counterParty == null && type != InvoiceType.SimplifiedInvoice)
            {
                throw new Exception($"{nameof(counterParty)} has to be specified if 'SimplifiedInvoice' is not used.");
            }

            Type = type;
            SchemeOrEffect = schemeOrEffect;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CounterParty = counterParty;
            TaxBreakdown = taxBreakdown ?? throw new ArgumentNullException(nameof(taxBreakdown));
            IssuedByThirdParty = issuedByThirdParty;
            TotalAmount = TaxBreakdown.TotalAmount;
        }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public LimitedString500 Description { get; }

        public decimal TotalAmount { get; }

        public CounterPartyCompany CounterParty { get; }

        public TaxBreakdown TaxBreakdown { get; }

        public bool IssuedByThirdParty { get; }
    }
}
