using FuncSharp;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class InvoiceItem
    {
        public InvoiceItem(TaxFreeItem[] taxFree = null, WithTaxItem withTax = null)
        {
            WithTax = withTax.ToOption();
            TaxFree = taxFree.ToNonEmptyOption();
            TaxFree.Where(i => i.Length > 7).Match(_ => throw new Exception("There can only be up to 7 tax exempt items on one invoice."));

            if (TaxFree.IsEmpty && WithTax == null)
            {
                throw new Exception("Invoice cannot be empty.");
            }
        }

        public IOption<TaxFreeItem[]> TaxFree { get; }

        public IOption<WithTaxItem> WithTax { get; }
    }
}
