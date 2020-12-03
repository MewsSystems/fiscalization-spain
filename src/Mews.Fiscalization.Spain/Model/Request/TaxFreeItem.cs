using FuncSharp;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class TaxFreeItem
    {
        public TaxFreeItem(Amount amount, CauseOfExemption? cause = null)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            Cause = cause.ToOption();
        }

        public Amount Amount { get; }

        public IOption<CauseOfExemption> Cause { get; }
    }
}
