using System;

namespace Mews.Fiscalization.Spain.Model
{
    public enum ResidenceCountryIdentificatorType
    {
        /// <summary>
        /// 02
        /// </summary>
        NifVat,

        /// <summary>
        /// 03
        /// </summary>
        Passport,

        /// <summary>
        /// 04
        /// </summary>
        OfficialIdentificationDocumentIssuedByTheCountry,

        /// <summary>
        /// 05
        /// </summary>
        ResidenceCertificate,

        /// <summary>
        /// 06
        /// </summary>
        OtherSupportingDocument
    }

    public enum SchemeOrEffect
    {
        /// <summary>
        /// 01
        /// </summary>
        GeneralTaxRegimeActivity,

        /// <summary>
        /// 02
        /// </summary>
        Export,

        /// <summary>
        /// 03
        /// </summary>
        WorksOfArt,

        /// <summary>
        /// 04
        /// </summary>
        InvestmentGold,

        /// <summary>
        /// 05
        /// </summary>
        TravelAgencies,

        /// <summary>
        /// 06
        /// </summary>
        GroupsOfEntities,

        /// <summary>
        /// 07
        /// </summary>
        CashBasis,

        /// <summary>
        /// 08
        /// </summary>
        CanaryIslandsGeneralIndirectTax,

        /// <summary>
        /// 09
        /// </summary>
        TravelAgencyServicesActingAsIntermediaries,

        /// <summary>
        /// 10
        /// </summary>
        Collections,

        /// <summary>
        /// 11
        /// </summary>
        BusinessPremisesLeaseActivities1,

        /// <summary>
        /// 12
        /// </summary>
        BusinessPremisesLeaseActivities2,

        /// <summary>
        /// 13
        /// </summary>
        BusinessPremisesLeaseActivities3,

        /// <summary>
        /// 14
        /// </summary>
        InvoiceWithVATPendingAccrual1,

        /// <summary>
        /// 15
        /// </summary>
        InvoiceWithVATPendingAccrual2
    }

    public enum InvoiceType
    {
        /// <summary>
        /// f1
        /// </summary>
        Invoice,

        /// <summary>
        /// F2
        /// </summary>
        SimplifiedInvoice,

        /// <summary>
        /// R1
        /// </summary>
        CorrectedInvoice,

        /// <summary>
        /// R2
        /// </summary>
        CorrectedInvoice2,

        /// <summary>
        /// R3
        /// </summary>
        CorrectedInvoice3,

        /// <summary>
        /// R4
        /// </summary>
        CorrectedInvoice4,

        /// <summary>
        /// R5
        /// </summary>
        CorrectedInvoiceInSimplifiedInvoices,

        /// <summary>
        /// F3
        /// </summary>
        InvoiceIssuedToReplaceSimplifiedInvoices,

        /// <summary>
        /// F4
        /// </summary>
        InvoiceSummaryEntry
    }

    public enum CommunicationType
    {
        /// <summary>
        /// A0
        /// </summary>
        Registration,

        /// <summary>
        /// A1
        /// </summary>
        Amendment,

        /// <summary>
        /// A4
        /// </summary>
        AmendmentForTravellers
    }

    public enum Month
    {
        /// <summary>
        /// 01
        /// </summary>
        January,

        /// <summary>
        /// 02
        /// </summary>
        February,

        /// <summary>
        /// 03
        /// </summary>
        March,

        /// <summary>
        /// 04
        /// </summary>
        April,

        /// <summary>
        /// 05
        /// </summary>
        May,

        /// <summary>
        /// 06
        /// </summary>
        June,

        /// <summary>
        /// 07
        /// </summary>
        July,

        /// <summary>
        /// 08
        /// </summary>
        August,

        /// <summary>
        /// 09
        /// </summary>
        September,

        /// <summary>
        /// 10
        /// </summary>
        October,

        /// <summary>
        /// 11
        /// </summary>
        November,

        /// <summary>
        /// 12
        /// </summary>
        December
    }

    public enum CauseOfExemption
    {
        /// <summary>
        /// E1
        /// </summary>
        ExemptOnAccountOfArticle20,

        /// <summary>
        /// E2
        /// </summary>
        ExemptOnAccountOfArticle21,

        /// <summary>
        /// E3
        /// </summary>
        ExemptOnAccountOfArticle22,

        /// <summary>
        /// E4
        /// </summary>
        ExemptOnAccountOfArticle24,

        /// <summary>
        /// E5
        /// </summary>
        ExemptOnAccountOfArticle25,

        /// <summary>
        /// E6
        /// </summary>
        ExemptOnOtherGrounds,
    }

    public enum TransactionType
    {
        /// <summary>
        /// S1
        /// </summary>
        NotExempt,

        /// <summary>
        /// S2
        /// </summary>
        InvTaxablePerson
    }

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

        public Invoice[] Invoices { get; }
    }

    public class Invoice
    {
        public Invoice(
            TaxPeriod taxPeriod,
            InvoiceId id,
            InvoiceType type,
            SchemeOrEffect schemeOrEffect,
            decimal totalAmount,
            string description,
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
        public decimal TotalAmount { get; }

        /// <summary>
        /// DescripciónOperación
        /// </summary>
        public string Description { get; }

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
        public TaxFreeItem(decimal amount, CauseOfExemption? cause = null)
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
        public decimal Amount { get; }
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
        public VATBreakdown(decimal taxRate, decimal taxBaseAmount, decimal taxAmount, decimal equivalenceSurchargePercentage, decimal equivalenceSurchargeTaxAmount)
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
        public decimal TaxRate { get; }

        /// <summary>
        /// BaseImponible
        /// </summary>
        public decimal TaxBaseAmount { get; }

        /// <summary>
        /// CuotaRepercutida
        /// </summary>
        public decimal TaxAmount { get; }

        /// <summary>
        /// TipoRecargoEquivalencia
        /// </summary>
        public decimal EquivalenceSurchargePercentage { get; }

        /// <summary>
        /// CuotaRecargoEquivalencia
        /// </summary>
        public decimal EquivalenceSurchargeTaxAmount { get; }
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
        public ForeignCompany(string countryCode, ResidenceCountryIdentificatorType identificatiorType, string id)
        {
            if (countryCode.Length != 2)
            {
                throw new ArgumentException($"{nameof(countryCode)} is not valid ISO 3166-1 alpha-2 country code.");
            }

            CountryCode = countryCode;
            IdentificatiorType = identificatiorType;
            Id = id;
        }

        /// <summary>
        /// CodigoPais
        /// </summary>
        public string CountryCode { get; }

        /// <summary>
        /// IDType
        /// </summary>
        public ResidenceCountryIdentificatorType IdentificatiorType { get; }

        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; }
    }

    public class InvoiceId
    {
        public InvoiceId(TaxPayerNumber issuer, string number, DateTime date)
        {
            if (number.Length > 60)
            {
                throw new ArgumentException($"{nameof(number)} cannot be longer than 60.");
            }

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
        public string Number { get; }

        /// <summary>
        /// FechaExpedicionFacturaEmisor
        /// </summary>
        public DateTime Date { get; }
    }

    public class TaxPeriod
    {
        public TaxPeriod(int year, Month month)
        {
            Year = year;
            Month = month;
        }

        /// <summary>
        /// Ejercicio
        /// </summary>
        public int Year { get; }

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
        public CompanyTitle(string name, TaxPayerNumber taxPayerNumber)
        {
            if (name.Length > 40)
            {
                throw new ArgumentException($"{nameof(name)} cannot be longer than 40.");
            }

            Name = name;
            TaxPayerNumber = taxPayerNumber;
        }

        /// <summary>
        /// NombreRazon
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// NIF
        /// </summary>
        public TaxPayerNumber TaxPayerNumber { get; }
    }

    public class TaxPayerNumber
    {
        public TaxPayerNumber(string number)
        {
            if (number.Length != 9)
            {
                throw new ArgumentException($"{nameof(number)} should be 9 characters.");
            }

            Number = number;
        }

        public string Number { get; }
    }
}
