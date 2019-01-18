using System;
using System.Text.RegularExpressions;
using FuncSharp;

namespace Mews.Fiscalization.Spain.Model
{
    public class InvoicesToRegister
    {
        public InvoicesToRegister(Header header, Invoice[] invoices)
        {
            if (invoices.Length > 10000)
            {
                throw new ArgumentException("Maximal count of invoices is 10000.");
            }

            Header = header;
            Invoices = invoices;
        }

        public Header Header { get; }

        public Invoice[] Invoices { get; }
    }

    public class Invoice
    {
        public Invoice(
            TaxPeriod taxPeriod,
            InvoiceId id,
            InvoiceType type,
            SchemeOrEffect schemeOrEffect,
            Amount totalAmount,
            LimitedString500 description,
            CounterPartyCompany counterParty,
            BreakdownItem breakdown)
        {
            TaxPeriod = taxPeriod;
            Id = id;
            Type = type;
            SchemeOrEffect = schemeOrEffect;
            TotalAmount = totalAmount;
            Description = description;
            Counterparty = counterParty;
            Breakdown = breakdown;
        }

        public TaxPeriod TaxPeriod { get; }

        public InvoiceId Id { get; }

        public InvoiceType Type { get; }

        public SchemeOrEffect SchemeOrEffect { get; }

        public Amount TotalAmount { get; }

        public LimitedString500 Description { get; }

        public CounterPartyCompany Counterparty { get; }

        public BreakdownItem Breakdown { get; }
    }

    public class BreakdownItem : Coproduct2<InvoiceItem, OperationTypeBreakdown>
    {
        public BreakdownItem(InvoiceItem firstValue)
            : base(firstValue)
        {
        }

        public BreakdownItem(OperationTypeBreakdown secondValue)
            : base(secondValue)
        {
        }
    }

    public class InvoiceItem : Coproduct2<TaxFreeItem[], WithTaxItem>
    {
        public InvoiceItem(TaxFreeItem[] taxFree)
            : base(taxFree)
        {
        }

        public InvoiceItem(WithTaxItem withTax)
            : base(withTax)
        {
        }
    }

    public class TaxFreeItem
    {
        public TaxFreeItem(Amount amount, CauseOfExemption? cause = null)
        {
            Cause = cause;
            Amount = amount;
        }

        public CauseOfExemption? Cause { get; }

        public Amount Amount { get; }
    }

    public class WithTaxItem
    {
        public WithTaxItem(TransactionType transactionType, VATBreakdown[] vatBreakdowns)
        {
            TransactionType = transactionType;
            VatBreakdowns = vatBreakdowns;
        }

        public TransactionType TransactionType { get; }

        public VATBreakdown[] VatBreakdowns { get; }
    }

    public class VATBreakdown
    {
        public VATBreakdown(Percentage taxRate, Amount taxBaseAmount, Amount taxAmount, Percentage equivalenceSurchargePercentage = null, Amount equivalenceSurchargeTaxAmount = null)
        {
            TaxRate = taxRate;
            TaxBaseAmount = taxBaseAmount;
            TaxAmount = taxAmount;
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
            ServiceProvision = serviceProvision;
            Delivery = delivery;
        }

        public InvoiceItem ServiceProvision { get; }

        public InvoiceItem Delivery { get; }
    }

    public class CounterPartyCompany : Coproduct2<LocalCompany, ForeignCompany>
    {
        public CounterPartyCompany(LocalCompany companyTitle)
            : base(companyTitle)
        {
        }

        public CounterPartyCompany(ForeignCompany foreignCompany)
            : base(foreignCompany)
        {
        }
    }

    public class ForeignCompany
    {
        public ForeignCompany(LimitedString120 name, Country country, ResidenceCountryIdentificatorType identificatiorType, LimitedString20 id)
        {
            Name = name;
            Country = country;
            IdentificatorType = identificatiorType;
            Id = id;
        }

        public LimitedString120 Name { get; }

        public Country Country { get; }

        public ResidenceCountryIdentificatorType IdentificatorType { get; }

        public LimitedString20 Id { get; }
    }

    public class InvoiceId
    {
        public InvoiceId(TaxPayerNumber issuer, LimitedString1to60 number, DateTime date)
        {
            Issuer = issuer;
            Number = number;
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
            Year = year;
            Month = month;
        }

        public Year Year { get; }

        public Month Month { get; }
    }

    public class Header
    {
        public Header(LocalCompany company, CommunicationType communicationType)
        {
            Company = company;
            CommunicationType = communicationType;
        }

        public LocalCompany Company { get; }

        public CommunicationType CommunicationType { get; }
    }

    public class LocalCompany
    {
        public LocalCompany(LimitedString120 name, TaxPayerNumber taxPayerNumber)
        {
            Name = name;
            TaxPayerNumber = taxPayerNumber;
        }

        public LimitedString120 Name { get; }

        public TaxPayerNumber TaxPayerNumber { get; }
    }

    public class TaxPayerNumber
    {
        public TaxPayerNumber(string number)
        {
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
