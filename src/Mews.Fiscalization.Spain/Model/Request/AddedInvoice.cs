using FuncSharp;
using System;
using System.Linq;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class AddedInvoice : Invoice
    {
        public AddedInvoice(
            TaxPeriod taxPeriod,
            InvoiceId id,
            InvoiceType type,
            SchemeOrEffect schemeOrEffect,
            LimitedString500 description,
            BreakdownItem breakdown,
            CounterPartyCompany counterParty = null)
            : base(taxPeriod, id)
        {
            if (counterParty == null && type != InvoiceType.SimplifiedInvoice)
            {
                throw new Exception($"{nameof(counterParty)} has to be specified if 'SimplifiedInvoice' is not used.");
            }

            Type = type;
            SchemeOrEffect = schemeOrEffect;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CounterParty = counterParty;
            Breakdown = breakdown ?? throw new ArgumentNullException(nameof(breakdown));
        }


        public Amount TotalAmount
        {
            get
            {
                return new Amount(Breakdown.Match(
                    invoiceItem => CalculateTotalWithTax(invoiceItem.WithTax).Value + CalculateTotalTaxFree(invoiceItem.TaxFree).Value,
                    breakdown =>
                    {
                        var deliveryItem = breakdown.Delivery;
                        var serviceProvisionItem = breakdown.ServiceProvision;
                        var totalDeliveryItems = CalculateTotalWithTax(deliveryItem.WithTax).Value + CalculateTotalTaxFree(deliveryItem.TaxFree).Value;
                        var totalServiceProvisionItems = CalculateTotalWithTax(serviceProvisionItem.WithTax).Value + CalculateTotalTaxFree(serviceProvisionItem.TaxFree).Value;
                        return totalDeliveryItems + totalServiceProvisionItems;
                    }
                ));
            }
        }

        public Amount CalculateTotalWithTax(IOption<WithTaxItem> withTaxItem)
        {
            return new Amount(withTaxItem.Match(
                item => item.VatBreakdowns.Sum(d =>
                    d.TaxBaseAmount.Value + d.TaxAmount.Value + (d.EquivalenceSurchargeTaxAmount.Map(a => a.Value).GetOrZero() * d.EquivalenceSurchargePercentage.Map(p => p.Value).GetOrZero())
                ),
                _ => 0
            ));
        }

        public Amount CalculateTotalTaxFree(IOption<TaxFreeItem[]> taxFreeItem)
        {
            return new Amount(taxFreeItem.Map(i => i.Sum(item => item.Amount.Value)).GetOrZero());
        }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public LimitedString500 Description { get; }

        public CounterPartyCompany CounterParty { get; }

        public BreakdownItem Breakdown { get; }
    }
}
