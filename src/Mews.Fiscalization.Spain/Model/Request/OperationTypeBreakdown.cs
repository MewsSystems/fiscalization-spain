using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class OperationTypeBreakdown
    {
        public OperationTypeBreakdown(InvoiceItem serviceProvision, InvoiceItem delivery)
        {
            ServiceProvision = serviceProvision ?? throw new ArgumentNullException(nameof(serviceProvision));
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        public InvoiceItem ServiceProvision { get; }

        public InvoiceItem Delivery { get; }
    }
}
