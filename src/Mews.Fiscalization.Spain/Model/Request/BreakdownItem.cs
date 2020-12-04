using FuncSharp;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class BreakdownItem : Coproduct2<InvoiceItem, OperationTypeBreakdown>
    {
        public BreakdownItem(InvoiceItem firstValue)
            : base(firstValue)
        {
            if (firstValue == null)
            {
                throw new ArgumentNullException(nameof(firstValue));
            }
        }

        public BreakdownItem(OperationTypeBreakdown secondValue)
            : base(secondValue)
        {
            if (secondValue == null)
            {
                throw new ArgumentNullException(nameof(secondValue));
            }
        }
    }
}
