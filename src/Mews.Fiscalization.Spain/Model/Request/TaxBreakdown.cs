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
        public TaxBreakdown(TaxSummary firstValue)
            : base(firstValue)
        {
            Check.IsNotNull(firstValue, nameof(firstValue));
        }

        public TaxBreakdown(OperationTypeTaxBreakdown secondValue)
            : base(secondValue)
        {
            Check.IsNotNull(secondValue, nameof(secondValue));
        }

        public decimal TotalAmount
        {
            get
            {
                return Match(
                    taxSummary => CalculateInvoiceItemTotalAmount(taxSummary),
                    operationTypeTaxBreakdown => CalculateInvoiceItemTotalAmount(operationTypeTaxBreakdown.Delivery) + CalculateInvoiceItemTotalAmount(operationTypeTaxBreakdown.ServiceProvision)
                );
            }
        }

        private decimal CalculateInvoiceItemTotalAmount(TaxSummary summary)
        {
            var taxFreeTotal = summary.TaxFree.Map(i => i.Sum(item => item.Amount.Value)).GetOrZero();
            var taxRateTotals = summary.Taxed.Flatten().Sum(s => s.TaxBaseAmount.Value + s.TaxAmount.Value);
            return taxFreeTotal + taxRateTotals;
        }
    }
}
