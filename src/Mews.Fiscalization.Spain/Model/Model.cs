using System;

namespace Mews.Fiscalization.Spain.Model
{
    public enum ResidenceCountryIdentificatorType
    {
        NifVat,
        Passport,
        OfficialIdentificationDocumentIssuedByTheCountry,
        ResidenceCertificate,
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

        #endregion
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
