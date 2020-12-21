using FuncSharp;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class TaxSummary
    {
        public TaxSummary(TaxFreeItem[] taxFree = null, TaxRateSummary[] taxed = null)
        {
            Taxed = taxed.ToNonEmptyOption();
            Taxed.Where(i => i.Length >= 7).Match(_ => throw new Exception("There can only be up to 6 distinct tax rates on one invoice."));

            TaxFree = taxFree.ToNonEmptyOption();
            TaxFree.Where(i => i.Length > 7).Match(_ => throw new Exception("There can only be up to 7 tax exempt items on one invoice."));

            if (TaxFree.IsEmpty && Taxed.IsEmpty)
            {
                throw new Exception("Invoice cannot be empty.");
            }
        }

        public IOption<TaxFreeItem[]> TaxFree { get; }

        public IOption<TaxRateSummary[]> Taxed { get; }
    }
}
