using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class OperationTypeTaxBreakdown
    {
        public OperationTypeTaxBreakdown(TaxSummary serviceProvision, TaxSummary delivery)
        {
            ServiceProvision = serviceProvision ?? throw new ArgumentNullException(nameof(serviceProvision));
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        public TaxSummary ServiceProvision { get; }

        public TaxSummary Delivery { get; }
    }
}
