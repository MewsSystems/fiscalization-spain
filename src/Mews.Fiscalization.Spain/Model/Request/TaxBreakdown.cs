using FuncSharp;
using Mews.Fiscalization.Core.Model;
using System;
using System.Linq;

namespace Mews.Fiscalization.Spain.Model.Request
{
    /// <summary>
    /// Either the revenue is broken down into service and delivery or it is just 1 tax summary altogether.
    /// </summary>
    public sealed class TaxBreakdown : Coproduct2<TaxSummary, OperationTypeTaxBreakdown>
    {
        public TaxBreakdown(TaxSummary summary)
            : base(summary)
        {
            Check.IsNotNull(summary, nameof(summary));
        }

        public TaxBreakdown(OperationTypeTaxBreakdown breakdown)
            : base(breakdown)
        {
            Check.IsNotNull(breakdown, nameof(breakdown));
        }

        public decimal TotalAmount
        {
            get
            {
                return Match(
                    taxSummary => CalculateTaxSummary(taxSummary.ToOption()),
                    operationTypeTaxBreakdown => CalculateTaxSummary(operationTypeTaxBreakdown.Delivery) + CalculateTaxSummary(operationTypeTaxBreakdown.ServiceProvision)
                );
            }
        }

        private decimal CalculateTaxSummary(IOption<TaxSummary> taxSummary)
        {
            return taxSummary.Match(
                summary =>
                {
                    var taxFreeTotal = summary.TaxFree.Map(i => i.Sum(item => item.Amount.Value)).GetOrZero();
                    var taxRateTotals = summary.Taxed.Flatten().Sum(s => s.TaxBaseAmount.Value + s.TaxAmount.Value);
                    return taxFreeTotal + taxRateTotals;
                },
                _ => 0
            );
        }
    }
}
