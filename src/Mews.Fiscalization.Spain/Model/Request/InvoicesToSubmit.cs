using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class InvoicesToSubmit
    {
        public InvoicesToSubmit(Header header, AddedInvoice[] addedInvoices)
        {
            Header = header ?? throw new ArgumentNullException(nameof(header));
            AddedInvoices = addedInvoices ?? throw new ArgumentNullException(nameof(addedInvoices));

            if (addedInvoices.Length > 10000)
            {
                throw new ArgumentException("Maximal count of invoices is 10000.");
            }

            if (addedInvoices.Length < 1)
            {
                throw new ArgumentException("Minimal count of invoices is 1.");
            }
        }

        public Header Header { get; }

        public AddedInvoice[] AddedInvoices { get; }
    }
}
