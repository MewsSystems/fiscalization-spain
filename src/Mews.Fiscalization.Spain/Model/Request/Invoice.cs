using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public class Invoice
    {
        public Invoice(
            TaxPeriod taxPeriod,
            InvoiceId id)
        {
            TaxPeriod = taxPeriod ?? throw new ArgumentNullException(nameof(taxPeriod));
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public TaxPeriod TaxPeriod { get; }

        public InvoiceId Id { get; }
    }
}
