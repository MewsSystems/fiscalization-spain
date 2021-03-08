using FuncSharp;
using Mews.Fiscalization.Core.Model;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class OperationTypeTaxBreakdown
    {
        public OperationTypeTaxBreakdown(TaxSummary serviceProvision = null, TaxSummary delivery = null)
        {
            Check.Condition(serviceProvision.IsNotNull() || delivery.IsNotNull(), "At least 1 tax summary must be provided.");
            ServiceProvision = serviceProvision.ToOption();
            Delivery = delivery.ToOption();
        }

        public IOption<TaxSummary> ServiceProvision { get; }

        public IOption<TaxSummary> Delivery { get; }
    }
}
