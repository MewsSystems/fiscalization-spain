﻿using FuncSharp;
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


        public decimal TotalAmount
        {
            get
            {
                return Breakdown.Match(
                    invoiceItem => CalculateTotalWithTax(invoiceItem.WithTax) + CalculateTotalTaxFree(invoiceItem.TaxFree),
                    breakdown =>
                    {
                        var deliveryItem = breakdown.Delivery;
                        var serviceProvisionItem = breakdown.ServiceProvision;
                        var totalDeliveryItems = CalculateTotalWithTax(deliveryItem.WithTax) + CalculateTotalTaxFree(deliveryItem.TaxFree);
                        var totalServiceProvisionItems = CalculateTotalWithTax(serviceProvisionItem.WithTax) + CalculateTotalTaxFree(serviceProvisionItem.TaxFree);
                        return totalDeliveryItems + totalServiceProvisionItems;
                    }
                );
            }
        }

        public decimal CalculateTotalWithTax(IOption<WithTaxItem> withTaxItem)
        {
            return withTaxItem.Match(
                item => item.VatBreakdowns.Sum(d =>
                    d.TaxBaseAmount.Value + d.TaxAmount.Value + (d.EquivalenceSurchargeTaxAmount.Map(a => a.Value).GetOrZero() * d.EquivalenceSurchargePercentage.Map(p => p.Value).GetOrZero())
                ),
                _ => 0
            );
        }

        public decimal CalculateTotalTaxFree(IOption<TaxFreeItem[]> taxFreeItem)
        {
            return taxFreeItem.Map(i => i.Sum(item => item.Amount.Value)).GetOrZero();
        }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public LimitedString500 Description { get; }

        public CounterPartyCompany CounterParty { get; }

        public BreakdownItem Breakdown { get; }
    }
}
