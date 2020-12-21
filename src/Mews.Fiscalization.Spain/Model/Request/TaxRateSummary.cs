using Mews.Fiscalization.Core.Model;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class TaxRateSummary
    {
        public TaxRateSummary(Percentage taxRate, Amount taxBaseAmount, Amount taxAmount)
        {
            TaxRate = Check.IsNotNull(taxRate, nameof(taxRate));
            TaxBaseAmount = Check.IsNotNull(taxBaseAmount, nameof(taxBaseAmount));
            TaxAmount = Check.IsNotNull(taxAmount, nameof(taxAmount));
        }

        public Percentage TaxRate { get; }

        public Amount TaxBaseAmount { get; }

        public Amount TaxAmount { get; }
    }
}
