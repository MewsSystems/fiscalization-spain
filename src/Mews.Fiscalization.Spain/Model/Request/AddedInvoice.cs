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
            bool issuedByThirdParty,
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
            IssuedByThirdParty = issuedByThirdParty;
        }


        public decimal TotalAmount
        {
            get
            {
                return Breakdown.Match(
                    invoiceItem => CalculateInvoiceItemTotalAmount(invoiceItem),
                    breakdown => CalculateInvoiceItemTotalAmount(breakdown.Delivery) + CalculateInvoiceItemTotalAmount(breakdown.ServiceProvision)
                );
            }
        }

        private decimal CalculateInvoiceItemTotalAmount(InvoiceItem item)
        {
            return CalculateTotalWithTax(item.WithTax) + CalculateTotalTaxFree(item.TaxFree);
        }

        private decimal CalculateTotalWithTax(IOption<WithTaxItem> withTaxItem)
        {
            return withTaxItem.Match(
                item => item.VatBreakdowns.Sum(d =>
                    d.TaxBaseAmount.Value + d.TaxAmount.Value + (d.EquivalenceSurchargeTaxAmount.Map(a => a.Value).GetOrZero() * d.EquivalenceSurchargePercentage.Map(p => p.Value).GetOrZero())
                ),
                _ => 0
            );
        }

        private decimal CalculateTotalTaxFree(IOption<TaxFreeItem[]> taxFreeItem)
        {
            return taxFreeItem.Map(i => i.Sum(item => item.Amount.Value)).GetOrZero();
        }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public LimitedString500 Description { get; }

        public CounterPartyCompany CounterParty { get; }

        public BreakdownItem Breakdown { get; }

        public bool IssuedByThirdParty { get; }
    }
}
