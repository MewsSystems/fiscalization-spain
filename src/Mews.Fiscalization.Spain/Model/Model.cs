using System;
using System.Text.RegularExpressions;

namespace Mews.Fiscalization.Spain.Model
{
    public class InvoicesToRegister
    {
        public InvoicesToRegister(Header header, Invoice[] invoices)
        {
            Header = header;
            Invoices = invoices;
        }

        /// <summary>
        /// Cabecera
        /// </summary>
        public Header Header { get; }

        /// <summary>
        /// RegistroLRfacturasRecibidas
        /// </summary>
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
            CounterPartyCompany counterparty,
            BreakdownKind breakdown)
        {
            TaxPeriod = taxPeriod;
            Id = id;
            Type = type;
            SchemeOrEffect = schemeOrEffect;
            TotalAmount = totalAmount;
            Description = description;
            Counterparty = counterparty;
            Breakdown = breakdown;
        }

        /// <summary>
        /// PeriodoImpositivo
        /// </summary>
        public TaxPeriod TaxPeriod { get; }

        /// <summary>
        /// IDFactura
        /// </summary>
        public InvoiceId Id { get; }

        #region FacturaExpedida

        /// <summary>
        /// TipoFactura
        /// </summary>
        public InvoiceType Type { get; }

        /// <summary>
        /// ClaveRegimenEspecialOTrascendencia
        /// </summary>
        public SchemeOrEffect SchemeOrEffect { get; }

        /// <summary>
        /// ImporteTotal
        /// </summary>
        public Amount TotalAmount { get; }

        /// <summary>
        /// DescripciónOperación
        /// </summary>
        public LimitedString500 Description { get; }

        /// <summary>
        /// Contraparte
        /// </summary>
        public CounterPartyCompany Counterparty { get; }

        /// <summary>
        /// TipoDesglose
        /// </summary>
        public BreakdownKind Breakdown { get; }

        #endregion
    }

    public class BreakdownKind
    {
        public BreakdownKind(InvoiceBreakdown invoiceBreakdown)
        {
            InvoiceBreakdown = invoiceBreakdown;
        }

        public BreakdownKind(OperationTypeBreakdown operationTypeBreakdown)
        {
            OperationTypeBreakdown = operationTypeBreakdown;
        }

        /// <summary>
        /// DesgloseFactura
        /// </summary>
        public InvoiceBreakdown InvoiceBreakdown { get; }

        /// <summary>
        /// DesgloseTipoOperacion
        /// </summary>
        public OperationTypeBreakdown OperationTypeBreakdown { get; }
    }

    public class InvoiceBreakdown
    {
        public InvoiceBreakdown(Item item)
        {
            Item = item;
        }

        /// <summary>
        /// Sujeta
        /// </summary>
        public Item Item { get; }
    }

    public class Item
    {
        public Item(TaxFreeItem[] taxFree)
        {
            TaxFree = taxFree;
        }

        public Item(WithTaxItem withTax)
        {
            WithTax = withTax;
        }

        /// <summary>
        /// Exenta
        /// </summary>
        public TaxFreeItem[] TaxFree { get; }

        /// <summary>
        /// NoExenta
        /// </summary>
        public WithTaxItem WithTax { get; }
    }

    public class TaxFreeItem
    {
        public TaxFreeItem(Amount amount, CauseOfExemption? cause = null)
        {
            Cause = cause;
            Amount = amount;
        }

        /// <summary>
        /// CausaExencion
        /// </summary>
        public CauseOfExemption? Cause { get; }

        /// <summary>
        /// BaseImponible
        /// </summary>
        public Amount Amount { get; }
    }

    public class WithTaxItem
    {
        public WithTaxItem(TransactionType transactionType, VATBreakdown[] vatBreakdowns)
        {
            TransactionType = transactionType;
            VatBreakdowns = vatBreakdowns;
        }

        /// <summary>
        /// TipoNoExenta
        /// </summary>
        public TransactionType TransactionType { get; }

        /// <summary>
        /// DesgloseIVA -> DetalleIVA
        /// </summary>
        public VATBreakdown[] VatBreakdowns { get; }
    }

    public class VATBreakdown
    {
        public VATBreakdown(Percentage taxRate, Amount taxBaseAmount, Amount taxAmount, Percentage equivalenceSurchargePercentage, Amount equivalenceSurchargeTaxAmount)
        {
            TaxRate = taxRate;
            TaxBaseAmount = taxBaseAmount;
            TaxAmount = taxAmount;
            EquivalenceSurchargePercentage = equivalenceSurchargePercentage;
            EquivalenceSurchargeTaxAmount = equivalenceSurchargeTaxAmount;
        }

        /// <summary>
        /// TipoImpositivo
        /// </summary>
        public Percentage TaxRate { get; }

        /// <summary>
        /// BaseImponible
        /// </summary>
        public Amount TaxBaseAmount { get; }

        /// <summary>
        /// CuotaRepercutida
        /// </summary>
        public Amount TaxAmount { get; }

        /// <summary>
        /// TipoRecargoEquivalencia
        /// </summary>
        public Percentage EquivalenceSurchargePercentage { get; }

        /// <summary>
        /// CuotaRecargoEquivalencia
        /// </summary>
        public Amount EquivalenceSurchargeTaxAmount { get; }
    }

    public class OperationTypeBreakdown
    {
        public OperationTypeBreakdown(InvoiceBreakdown serviceProvision, InvoiceBreakdown delivery)
        {
            ServiceProvision = serviceProvision;
            Delivery = delivery;
        }

        /// <summary>
        /// PrestacionServicios
        /// </summary>
        public InvoiceBreakdown ServiceProvision { get; }

        /// <summary>
        /// Entrega
        /// </summary>
        public InvoiceBreakdown Delivery { get; }
    }

    public class CounterPartyCompany
    {
        public CounterPartyCompany(CompanyTitle companyTitle)
        {
            CompanyTitle = companyTitle;
        }

        public CounterPartyCompany(ForeignCompany foreignCompany)
        {
            ForeignCompany = foreignCompany;
        }

        /// <summary>
        /// NombreRazón, NIFRepresentante, NIF
        /// </summary>
        public CompanyTitle CompanyTitle { get; }

        /// <summary>
        /// IDOtro
        /// </summary>
        public ForeignCompany ForeignCompany { get; }
    }

    public class ForeignCompany
    {
        public ForeignCompany(Country country, ResidenceCountryIdentificatorType identificatiorType, LimitedString20 id)
        {
            Country = country;
            IdentificatiorType = identificatiorType;
            Id = id;
        }

        /// <summary>
        /// CodigoPais
        /// </summary>
        public Country Country { get; }

        /// <summary>
        /// IDType
        /// </summary>
        public ResidenceCountryIdentificatorType IdentificatiorType { get; }

        /// <summary>
        /// ID
        /// </summary>
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

        /// <summary>
        /// IDEmisorFactura
        /// </summary>
        public TaxPayerNumber Issuer { get; }

        /// <summary>
        /// NumSerieFacturaEmisor
        /// </summary>
        public LimitedString1to60 Number { get; }

        /// <summary>
        /// FechaExpedicionFacturaEmisor
        /// </summary>
        public DateTime Date { get; }
    }

    public class TaxPeriod
    {
        public TaxPeriod(Year year, Month month)
        {
            Year = year;
            Month = month;
        }

        /// <summary>
        /// Ejercicio
        /// </summary>
        public Year Year { get; }

        /// <summary>
        /// Periodo
        /// </summary>
        public Month Month { get; }
    }

    public class Header
    {
        /// <summary>
        /// IDVersionSii
        /// </summary>
        public readonly string ApiVersion = "1.1";

        public Header(CompanyTitle companyTitle, CommunicationType communicationType)
        {
            CompanyTitle = companyTitle;
            CommunicationType = communicationType;
        }

        /// <summary>
        /// Titular
        /// </summary>
        public CompanyTitle CompanyTitle { get; }

        /// <summary>
        /// TipoComunicacion
        /// </summary>
        public CommunicationType CommunicationType { get; }
    }

    public class CompanyTitle
    {
        public CompanyTitle(LimitedString120 name, TaxPayerNumber taxPayerNumber)
        {
            Name = name;
            TaxPayerNumber = taxPayerNumber;
        }

        /// <summary>
        /// NombreRazon
        /// </summary>
        public LimitedString120 Name { get; }

        /// <summary>
        /// NIF
        /// </summary>
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
