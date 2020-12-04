using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class InvoicesToDelete
    {
        public InvoicesToDelete(Header header, Invoice[] invoices)
        {
            Header = header ?? throw new ArgumentNullException(nameof(header));
            Invoices = invoices ?? throw new ArgumentNullException(nameof(invoices));

            if (invoices.Length > 10000)
            {
                throw new ArgumentException("Maximal count of invoices is 10000.");
            }

            if (invoices.Length < 1)
            {
                throw new ArgumentException("Minimal count of invoices is 1.");
            }
        }

        public Header Header { get; }

        public Invoice[] Invoices { get; }
    }
}
