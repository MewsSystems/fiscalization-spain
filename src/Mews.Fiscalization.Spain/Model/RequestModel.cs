﻿using System;
using System.Text.RegularExpressions;
using FuncSharp;

namespace Mews.Fiscalization.Spain.Model
{
    public class InvoicesToSubmit
    {
        public InvoicesToSubmit(Header header, AddedInvoice[] addedInvoices)
        {
            Header = header ?? throw new ArgumentNullException(nameof(header));
            AddedInvoices = addedInvoices ?? throw new ArgumentNullException(nameof(addedInvoices));

            if (addedInvoices.Length > 10000)
            {
                throw new ArgumentException("Maximal count of invoices is 10000.");
            }

            if (addedInvoices.Length < 1)
            {
                throw new ArgumentException("Minimal count of invoices is 1.");
            }
        }

        public Header Header { get; }

        public AddedInvoice[] AddedInvoices { get; }
    }

    public class InvoicesToDelete
    {
        public InvoicesToDelete(Header header, Invoice[] invoices)
        {
            Header = header ?? throw new ArgumentNullException(nameof(header));
            Invoices = invoices ?? throw new ArgumentNullException(nameof(invoices));

            if (invoices.Length > 10000)
            {
                throw new ArgumentException("Maximal count of invoices is 10000.");
            }

            if (invoices.Length < 1)
            {
                throw new ArgumentException("Minimal count of invoices is 1.");
            }
        }

        public Header Header { get; }

        public Invoice[] Invoices { get; }
    }

    public class Invoice
    {
        public Invoice(
            TaxPeriod taxPeriod,
            InvoiceId id)
        {
            TaxPeriod = taxPeriod ?? throw new ArgumentNullException(nameof(taxPeriod));
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public TaxPeriod TaxPeriod { get; }

        public InvoiceId Id { get; }
    }

    public class AddedInvoice : Invoice
    {
        public AddedInvoice(
            TaxPeriod taxPeriod,
            InvoiceId id,
            InvoiceType type,
            SchemeOrEffect schemeOrEffect,
            Amount totalAmount,
            LimitedString500 description,
            BreakdownItem breakdown,
            CounterPartyCompany counterParty = null)
            : base(taxPeriod, id)
        {
            if (counterParty == null && type != InvoiceType.SimplifiedInvoice)
            {
                throw new ArgumentNullException($"{nameof(counterParty)} has to be specified if 'SimplifiedInvoice' is not used.");
            }

            Type = type;
            SchemeOrEffect = schemeOrEffect;
            TotalAmount = totalAmount ?? throw new ArgumentNullException(nameof(totalAmount));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CounterParty = counterParty;
            Breakdown = breakdown ?? throw new ArgumentNullException(nameof(breakdown));
        }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public Amount TotalAmount { get; }

        public LimitedString500 Description { get; }

        public CounterPartyCompany CounterParty { get; }

        public BreakdownItem Breakdown { get; }
    }

    public class BreakdownItem : Coproduct2<InvoiceItem, OperationTypeBreakdown>
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

    public class InvoiceItem
    {
        public InvoiceItem(TaxFreeItem[] taxFree = null, WithTaxItem withTax = null)
        {
            TaxFree = taxFree.ToNonEmptyOption();

            if (TaxFree.IsEmpty && withTax == null)
            {
                throw new ArgumentException("Item cannot be empty");
            }

            WithTax = withTax.ToOption();
        }

        public IOption<TaxFreeItem[]> TaxFree { get; }

        public IOption<WithTaxItem> WithTax { get; }
    }

    public class TaxFreeItem
    {
        public TaxFreeItem(Amount amount, CauseOfExemption? cause = null)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            Cause = cause.ToOption();
        }

        public Amount Amount { get; }

        public IOption<CauseOfExemption> Cause { get; }
    }

    public class WithTaxItem
    {
        public WithTaxItem(TransactionType transactionType, VATBreakdown[] vatBreakdowns)
        {
            TransactionType = transactionType;
            VatBreakdowns = vatBreakdowns ?? throw new ArgumentNullException(nameof(vatBreakdowns));
        }

        public TransactionType TransactionType { get; }

        public VATBreakdown[] VatBreakdowns { get; }
    }

    public class VATBreakdown
    {
        public VATBreakdown(Percentage taxRate, Amount taxBaseAmount, Amount taxAmount, Percentage equivalenceSurchargePercentage = null, Amount equivalenceSurchargeTaxAmount = null)
        {
            TaxRate = taxRate ?? throw new ArgumentNullException(nameof(taxRate));
            TaxBaseAmount = taxBaseAmount ?? throw new ArgumentNullException(nameof(taxBaseAmount));
            TaxAmount = taxAmount ?? throw new ArgumentNullException(nameof(taxAmount));
            EquivalenceSurchargePercentage = equivalenceSurchargePercentage.ToOption();
            EquivalenceSurchargeTaxAmount = equivalenceSurchargeTaxAmount.ToOption();
        }

        public Percentage TaxRate { get; }

        public Amount TaxBaseAmount { get; }

        public Amount TaxAmount { get; }

        public IOption<Percentage> EquivalenceSurchargePercentage { get; }

        public IOption<Amount> EquivalenceSurchargeTaxAmount { get; }
    }

    public class OperationTypeBreakdown
    {
        public OperationTypeBreakdown(InvoiceItem serviceProvision, InvoiceItem delivery)
        {
            ServiceProvision = serviceProvision ?? throw new ArgumentNullException(nameof(serviceProvision));
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        public InvoiceItem ServiceProvision { get; }

        public InvoiceItem Delivery { get; }
    }

    public class CounterPartyCompany : Coproduct2<LocalCompany, ForeignCompany>
    {
        public CounterPartyCompany(LocalCompany companyTitle)
            : base(companyTitle)
        {
            if (companyTitle == null)
            {
                throw new ArgumentNullException(nameof(companyTitle));
            }
        }

        public CounterPartyCompany(ForeignCompany foreignCompany)
            : base(foreignCompany)
        {
            if (foreignCompany == null)
            {
                throw new ArgumentNullException(nameof(foreignCompany));
            }
        }
    }

    public class ForeignCompany
    {
        public ForeignCompany(LimitedString120 name, ResidenceCountryIdentificatorType identificatiorType, LimitedString20 id, Country country = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Country = country.ToOption();
            IdentificatorType = identificatiorType;
            Id = id ?? throw new ArgumentNullException(nameof(id));

            if (Country.IsEmpty)
            {
                try
                {
                    var countryCode = Id.Value.Substring(0, 2);
                    new Country(countryCode);
                }
                catch (Exception)
                {
                    throw new ArgumentException($"{nameof(country)} has to be specified if {nameof(id)} doesn't start with country code.");
                }
            }
        }

        public LimitedString120 Name { get; }

        public IOption<Country> Country { get; }

        public ResidenceCountryIdentificatorType IdentificatorType { get; }

        public LimitedString20 Id { get; }
    }

    public class InvoiceId
    {
        public InvoiceId(TaxPayerNumber issuer, LimitedString1to60 number, DateTime date)
        {
            Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
            Number = number ?? throw new ArgumentNullException(nameof(number));
            Date = date;
        }

        public TaxPayerNumber Issuer { get; }

        public LimitedString1to60 Number { get; }

        public DateTime Date { get; }
    }

    public class TaxPeriod
    {
        public TaxPeriod(Year year, Month month)
        {
            Year = year ?? throw new ArgumentNullException(nameof(year));
            Month = month;
        }

        public Year Year { get; }

        public Month Month { get; }
    }

    public class Header
    {
        public Header(LocalCompany company, CommunicationType communicationType)
        {
            Company = company ?? throw new ArgumentNullException(nameof(company));
            CommunicationType = communicationType;
        }

        public LocalCompany Company { get; }

        public CommunicationType CommunicationType { get; }
    }

    public class LocalCompany
    {
        public LocalCompany(LimitedString120 name, TaxPayerNumber taxPayerNumber)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            TaxPayerNumber = taxPayerNumber ?? throw new ArgumentNullException(nameof(taxPayerNumber));
        }

        public LimitedString120 Name { get; }

        public TaxPayerNumber TaxPayerNumber { get; }
    }

    public class TaxPayerNumber
    {
        public TaxPayerNumber(string number)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            var pattern = @"(([a-z|A-Z]{1}\d{7}[a-z|A-Z]{1})|(\d{8}[a-z|A-Z]{1})|([a-z|A-Z]{1}\d{8}))";
            var isValid = Regex.IsMatch(number, pattern) && number.Length == 9;
            if (!isValid)
            {
                throw new ArgumentException($"{nameof(number)} is not valid tax payer number.");
            }

            Number = number;
        }

        public string Number { get; }
    }
}
