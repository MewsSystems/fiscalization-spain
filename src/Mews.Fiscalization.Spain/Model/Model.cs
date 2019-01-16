using System;
using System.Text.RegularExpressions;

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
        December,
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

    public enum Country
    {
        /// <summary>
        /// AD
        /// <summary>
        Andorra,

        /// <summary>
        /// AE
        /// <summary>
        UnitedArabEmirates,

        /// <summary>
        /// AF
        /// <summary>
        Afghanistan,

        /// <summary>
        /// AG
        /// <summary>
        AntiguaandBarbuda,

        /// <summary>
        /// AI
        /// <summary>
        Anguilla,

        /// <summary>
        /// AL
        /// <summary>
        Albania,

        /// <summary>
        /// AM
        /// <summary>
        Armenia,

        /// <summary>
        /// AO
        /// <summary>
        Angola,

        /// <summary>
        /// AQ
        /// <summary>
        Antarctica,

        /// <summary>
        /// AR
        /// <summary>
        Argentina,

        /// <summary>
        /// AS
        /// <summary>
        AmericanSamoa,

        /// <summary>
        /// AT
        /// <summary>
        Austria,

        /// <summary>
        /// AU
        /// <summary>
        Australia,

        /// <summary>
        /// AW
        /// <summary>
        Aruba,

        /// <summary>
        /// AZ
        /// <summary>
        Azerbaijan,

        /// <summary>
        /// BA
        /// <summary>
        BosniaandHerzegovina,

        /// <summary>
        /// BB
        /// <summary>
        Barbados,

        /// <summary>
        /// BD
        /// <summary>
        Bangladesh,

        /// <summary>
        /// BE
        /// <summary>
        Belgium,

        /// <summary>
        /// BF
        /// <summary>
        BurkinaFaso,

        /// <summary>
        /// BG
        /// <summary>
        Bulgaria,

        /// <summary>
        /// BH
        /// <summary>
        Bahrain,

        /// <summary>
        /// BI
        /// <summary>
        Burundi,

        /// <summary>
        /// BJ
        /// <summary>
        Benin,

        /// <summary>
        /// BM
        /// <summary>
        Bermuda,

        /// <summary>
        /// BN
        /// <summary>
        BruneiDarussalam,

        /// <summary>
        /// BO
        /// <summary>
        Bolivia,

        /// <summary>
        /// BQ
        /// <summary>
        Bonaire, SintEustatiusandSaba,

        /// <summary>
        /// BR
        /// <summary>
        Brazil,

        /// <summary>
        /// BS
        /// <summary>
        Bahamas,

        /// <summary>
        /// BT
        /// <summary>
        Bhutan,

        /// <summary>
        /// BV
        /// <summary>
        BouvetIsland,

        /// <summary>
        /// BW
        /// <summary>
        Botswana,

        /// <summary>
        /// BY
        /// <summary>
        Belarus,

        /// <summary>
        /// BZ
        /// <summary>
        Belize,

        /// <summary>
        /// CA
        /// <summary>
        Canada,

        /// <summary>
        /// CC
        /// <summary>
        CocosKeelingIslands,

        /// <summary>
        /// CD
        /// <summary>
        DemocraticRepublicOfTheCongo,

        /// <summary>
        /// CF
        /// <summary>
        CentralAfricanRepublic,

        /// <summary>
        /// CG
        /// <summary>
        RepublicOfTheCongo,

        /// <summary>
        /// CH
        /// <summary>
        Switzerland,

        /// <summary>
        /// CI
        /// <summary>
        IvoryCoast,

        /// <summary>
        /// CK
        /// <summary>
        CookIslands,

        /// <summary>
        /// CL
        /// <summary>
        Chile,

        /// <summary>
        /// CM
        /// <summary>
        Cameroon,

        /// <summary>
        /// CN
        /// <summary>
        China,

        /// <summary>
        /// CO
        /// <summary>
        Colombia,

        /// <summary>
        /// CR
        /// <summary>
        CostaRica,

        /// <summary>
        /// CU
        /// <summary>
        Cuba,

        /// <summary>
        /// CV
        /// <summary>
        CaboVerde,

        /// <summary>
        /// CW
        /// <summary>
        Curaçao,

        /// <summary>
        /// CX
        /// <summary>
        ChristmasIsland,

        /// <summary>
        /// CY
        /// <summary>
        Cyprus,

        /// <summary>
        /// CZ
        /// <summary>
        Czechia,

        /// <summary>
        /// DE
        /// <summary>
        Germany,

        /// <summary>
        /// DJ
        /// <summary>
        Djibouti,

        /// <summary>
        /// DK
        /// <summary>
        Denmark,

        /// <summary>
        /// DM
        /// <summary>
        Dominica,

        /// <summary>
        /// DO
        /// <summary>
        DominicanRepublic,

        /// <summary>
        /// DZ
        /// <summary>
        Algeria,

        /// <summary>
        /// EC
        /// <summary>
        Ecuador,

        /// <summary>
        /// EE
        /// <summary>
        Estonia,

        /// <summary>
        /// EG
        /// <summary>
        Egypt,

        /// <summary>
        /// ER
        /// <summary>
        Eritrea,

        /// <summary>
        /// ES
        /// <summary>
        Spain,

        /// <summary>
        /// ET
        /// <summary>
        Ethiopia,

        /// <summary>
        /// FI
        /// <summary>
        Finland,

        /// <summary>
        /// FJ
        /// <summary>
        Fiji,

        /// <summary>
        /// FK
        /// <summary>
        FalklandIslands,

        /// <summary>
        /// FM
        /// <summary>
        Micronesia,

        /// <summary>
        /// FO
        /// <summary>
        FaroeIslands,

        /// <summary>
        /// FR
        /// <summary>
        France,

        /// <summary>
        /// GA
        /// <summary>
        Gabon,

        /// <summary>
        /// GB
        /// <summary>
        UnitedKingdomofGreatBritainandNorthernIreland,

        /// <summary>
        /// GD
        /// <summary>
        Grenada,

        /// <summary>
        /// GE
        /// <summary>
        Georgia,

        /// <summary>
        /// GG
        /// <summary>
        Guernsey,

        /// <summary>
        /// GH
        /// <summary>
        Ghana,

        /// <summary>
        /// GI
        /// <summary>
        Gibraltar,

        /// <summary>
        /// GL
        /// <summary>
        Greenland,

        /// <summary>
        /// GM
        /// <summary>
        Gambia,

        /// <summary>
        /// GN
        /// <summary>
        Guinea,

        /// <summary>
        /// GQ
        /// <summary>
        EquatorialGuinea,

        /// <summary>
        /// GR
        /// <summary>
        Greece,

        /// <summary>
        /// GS
        /// <summary>
        SouthGeorgiaandtheSouthSandwichIslands,

        /// <summary>
        /// GT
        /// <summary>
        Guatemala,

        /// <summary>
        /// GU
        /// <summary>
        Guam,

        /// <summary>
        /// GW
        /// <summary>
        GuineaBissau,

        /// <summary>
        /// GY
        /// <summary>
        Guyana,

        /// <summary>
        /// HK
        /// <summary>
        HongKong,

        /// <summary>
        /// HM
        /// <summary>
        HeardIslandandMcDonaldIslands,

        /// <summary>
        /// HN
        /// <summary>
        Honduras,

        /// <summary>
        /// HR
        /// <summary>
        Croatia,

        /// <summary>
        /// HT
        /// <summary>
        Haiti,

        /// <summary>
        /// HU
        /// <summary>
        Hungary,

        /// <summary>
        /// ID
        /// <summary>
        Indonesia,

        /// <summary>
        /// IE
        /// <summary>
        Ireland,

        /// <summary>
        /// IL
        /// <summary>
        Israel,

        /// <summary>
        /// IM
        /// <summary>
        IsleofMan,

        /// <summary>
        /// IN
        /// <summary>
        India,

        /// <summary>
        /// IO
        /// <summary>
        BritishIndianOceanTerritory,

        /// <summary>
        /// IQ
        /// <summary>
        Iraq,

        /// <summary>
        /// IR
        /// <summary>
        Iran,

        /// <summary>
        /// IS
        /// <summary>
        Iceland,

        /// <summary>
        /// IT
        /// <summary>
        Italy,

        /// <summary>
        /// JE
        /// <summary>
        Jersey,

        /// <summary>
        /// JM
        /// <summary>
        Jamaica,

        /// <summary>
        /// JO
        /// <summary>
        Jordan,

        /// <summary>
        /// JP
        /// <summary>
        Japan,

        /// <summary>
        /// KE
        /// <summary>
        Kenya,

        /// <summary>
        /// KG
        /// <summary>
        Kyrgyzstan,

        /// <summary>
        /// KH
        /// <summary>
        Cambodia,

        /// <summary>
        /// KI
        /// <summary>
        Kiribati,

        /// <summary>
        /// KM
        /// <summary>
        Comoros,

        /// <summary>
        /// KN
        /// <summary>
        SaintKittsandNevis,

        /// <summary>
        /// KP
        /// <summary>
        NorthKorea,

        /// <summary>
        /// KR
        /// <summary>
        SouthKorea,

        /// <summary>
        /// KW
        /// <summary>
        Kuwait,

        /// <summary>
        /// KY
        /// <summary>
        CaymanIslands,

        /// <summary>
        /// KZ
        /// <summary>
        Kazakhstan,

        /// <summary>
        /// LA
        /// <summary>
        Laos,

        /// <summary>
        /// LB
        /// <summary>
        Lebanon,

        /// <summary>
        /// LC
        /// <summary>
        SaintLucia,

        /// <summary>
        /// LI
        /// <summary>
        Liechtenstein,

        /// <summary>
        /// LK
        /// <summary>
        SriLanka,

        /// <summary>
        /// LR
        /// <summary>
        Liberia,

        /// <summary>
        /// LS
        /// <summary>
        Lesotho,

        /// <summary>
        /// LT
        /// <summary>
        Lithuania,

        /// <summary>
        /// LU
        /// <summary>
        Luxembourg,

        /// <summary>
        /// LV
        /// <summary>
        Latvia,

        /// <summary>
        /// LY
        /// <summary>
        Libya,

        /// <summary>
        /// MA
        /// <summary>
        Morocco,

        /// <summary>
        /// MC
        /// <summary>
        Monaco,

        /// <summary>
        /// MD
        /// <summary>
        Moldova,

        /// <summary>
        /// ME
        /// <summary>
        Montenegro,

        /// <summary>
        /// MG
        /// <summary>
        Madagascar,

        /// <summary>
        /// MH
        /// <summary>
        MarshallIslands,

        /// <summary>
        /// MK
        /// <summary>
        Macedonia,

        /// <summary>
        /// ML
        /// <summary>
        Mali,

        /// <summary>
        /// MM
        /// <summary>
        Myanmar,

        /// <summary>
        /// MN
        /// <summary>
        Mongolia,

        /// <summary>
        /// MO
        /// <summary>
        Macao,

        /// <summary>
        /// MP
        /// <summary>
        NorthernMarianaIslands,

        /// <summary>
        /// MR
        /// <summary>
        Mauritania,

        /// <summary>
        /// MS
        /// <summary>
        Montserrat,

        /// <summary>
        /// MT
        /// <summary>
        Malta,

        /// <summary>
        /// MU
        /// <summary>
        Mauritius,

        /// <summary>
        /// MV
        /// <summary>
        Maldives,

        /// <summary>
        /// MW
        /// <summary>
        Malawi,

        /// <summary>
        /// MX
        /// <summary>
        Mexico,

        /// <summary>
        /// MY
        /// <summary>
        Malaysia,

        /// <summary>
        /// MZ
        /// <summary>
        Mozambique,

        /// <summary>
        /// NA
        /// <summary>
        Namibia,

        /// <summary>
        /// NC
        /// <summary>
        NewCaledonia,

        /// <summary>
        /// NE
        /// <summary>
        Niger,

        /// <summary>
        /// NF
        /// <summary>
        NorfolkIsland,

        /// <summary>
        /// NG
        /// <summary>
        Nigeria,

        /// <summary>
        /// NI
        /// <summary>
        Nicaragua,

        /// <summary>
        /// NL
        /// <summary>
        Netherlands,

        /// <summary>
        /// NO
        /// <summary>
        Norway,

        /// <summary>
        /// NP
        /// <summary>
        Nepal,

        /// <summary>
        /// NR
        /// <summary>
        Nauru,

        /// <summary>
        /// NU
        /// <summary>
        Niue,

        /// <summary>
        /// NZ
        /// <summary>
        NewZealand,

        /// <summary>
        /// OM
        /// <summary>
        Oman,

        /// <summary>
        /// PA
        /// <summary>
        Panama,

        /// <summary>
        /// PE
        /// <summary>
        Peru,

        /// <summary>
        /// PF
        /// <summary>
        FrenchPolynesia,

        /// <summary>
        /// PG
        /// <summary>
        PapuaNewGuinea,

        /// <summary>
        /// PH
        /// <summary>
        Philippines,

        /// <summary>
        /// PK
        /// <summary>
        Pakistan,

        /// <summary>
        /// PL
        /// <summary>
        Poland,

        /// <summary>
        /// PM
        /// <summary>
        SaintPierreandMiquelon,

        /// <summary>
        /// PN
        /// <summary>
        Pitcairn,

        /// <summary>
        /// PR
        /// <summary>
        PuertoRico,

        /// <summary>
        /// PS
        /// <summary>
        Palestine, Stateof,

        /// <summary>
        /// PT
        /// <summary>
        Portugal,

        /// <summary>
        /// PW
        /// <summary>
        Palau,

        /// <summary>
        /// PY
        /// <summary>
        Paraguay,

        /// <summary>
        /// QA
        /// <summary>
        Qatar,

        /// <summary>
        /// RO
        /// <summary>
        Romania,

        /// <summary>
        /// RS
        /// <summary>
        Serbia,

        /// <summary>
        /// RU
        /// <summary>
        RussianFederation,

        /// <summary>
        /// RW
        /// <summary>
        Rwanda,

        /// <summary>
        /// SA
        /// <summary>
        SaudiArabia,

        /// <summary>
        /// SB
        /// <summary>
        SolomonIslands,

        /// <summary>
        /// SC
        /// <summary>
        Seychelles,

        /// <summary>
        /// SD
        /// <summary>
        Sudan,

        /// <summary>
        /// SE
        /// <summary>
        Sweden,

        /// <summary>
        /// SG
        /// <summary>
        Singapore,

        /// <summary>
        /// SH
        /// <summary>
        SaintHelena, AscensionandTristandaCunha,

        /// <summary>
        /// SI
        /// <summary>
        Slovenia,

        /// <summary>
        /// SK
        /// <summary>
        Slovakia,

        /// <summary>
        /// SL
        /// <summary>
        SierraLeone,

        /// <summary>
        /// SM
        /// <summary>
        SanMarino,

        /// <summary>
        /// SN
        /// <summary>
        Senegal,

        /// <summary>
        /// SO
        /// <summary>
        Somalia,

        /// <summary>
        /// SR
        /// <summary>
        Suriname,

        /// <summary>
        /// SS
        /// <summary>
        SouthSudan,

        /// <summary>
        /// ST
        /// <summary>
        SaoTomeandPrincipe,

        /// <summary>
        /// SV
        /// <summary>
        ElSalvador,

        /// <summary>
        /// SX
        /// <summary>
        SintMaartenDutchpart,

        /// <summary>
        /// SY
        /// <summary>
        SyrianArabRepublic,

        /// <summary>
        /// SZ
        /// <summary>
        Eswatini,

        /// <summary>
        /// TC
        /// <summary>
        TurksandCaicosIslands,

        /// <summary>
        /// TD
        /// <summary>
        Chad,

        /// <summary>
        /// TF
        /// <summary>
        FrenchSouthernTerritories,

        /// <summary>
        /// TG
        /// <summary>
        Togo,

        /// <summary>
        /// TH
        /// <summary>
        Thailand,

        /// <summary>
        /// TJ
        /// <summary>
        Tajikistan,

        /// <summary>
        /// TK
        /// <summary>
        Tokelau,

        /// <summary>
        /// TL
        /// <summary>
        TimorLeste,

        /// <summary>
        /// TM
        /// <summary>
        Turkmenistan,

        /// <summary>
        /// TN
        /// <summary>
        Tunisia,

        /// <summary>
        /// TO
        /// <summary>
        Tonga,

        /// <summary>
        /// TR
        /// <summary>
        Turkey,

        /// <summary>
        /// TT
        /// <summary>
        TrinidadandTobago,

        /// <summary>
        /// TV
        /// <summary>
        Tuvalu,

        /// <summary>
        /// TW
        /// <summary>
        Taiwan, ProvinceofChina,

        /// <summary>
        /// TZ
        /// <summary>
        Tanzania, UnitedRepublicof,

        /// <summary>
        /// UA
        /// <summary>
        Ukraine,

        /// <summary>
        /// UG
        /// <summary>
        Uganda,

        /// <summary>
        /// UM
        /// <summary>
        UnitedStatesMinorOutlyingIslands,

        /// <summary>
        /// US
        /// <summary>
        UnitedStatesofAmerica,

        /// <summary>
        /// UY
        /// <summary>
        Uruguay,

        /// <summary>
        /// UZ
        /// <summary>
        Uzbekistan,

        /// <summary>
        /// VA
        /// <summary>
        HolySee,

        /// <summary>
        /// VC
        /// <summary>
        SaintVincentandtheGrenadines,

        /// <summary>
        /// VE
        /// <summary>
        Venezuela,

        /// <summary>
        /// VG
        /// <summary>
        VirginIslandsBritish,

        /// <summary>
        /// VI
        /// <summary>
        VirginIslandsUS,

        /// <summary>
        /// VN
        /// <summary>
        VietNam,

        /// <summary>
        /// VU
        /// <summary>
        Vanuatu,

        /// <summary>
        /// WF
        /// <summary>
        WallisandFutuna,

        /// <summary>
        /// WS
        /// <summary>
        Samoa,

        /// <summary>
        /// YE
        /// <summary>
        Yemen,

        /// <summary>
        /// YT
        /// <summary>
        Mayotte,

        /// <summary>
        /// ZA
        /// <summary>
        SouthAfrica,

        /// <summary>
        /// ZM
        /// <summary>
        Zambia,

        /// <summary>
        /// ZW
        /// <summary>
        Zimbabwe
    }

    public class Amount
    {
        public Amount(decimal value)
        {
            var isValidAmount = value < 1000000000000 && value == Math.Round(value, 2);
            if (!isValidAmount)
            {
                throw new ArgumentException($"{nameof(value)} is not valid amount number.");
            }

            Value = value;
        }

        public decimal Value { get; }
    }

    public class Percentage
    {
        public Percentage(decimal value)
        {
            var isValidPercentage = value >= 0 && value <= 100 && value == Math.Round(value, 2);
            if (!isValidPercentage)
            {
                throw new ArgumentException($"{nameof(value)} is not valid percentage number.");
            }

            Value = value;
        }

        public decimal Value { get; }
    }

    public abstract class LimitedString
    {
        public LimitedString(string value, int minLength, int maxLength)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Max length of string is {maxLength}.");
            }

            if (value.Length < minLength)
            {
                throw new ArgumentException($"Min length of string is {minLength}.");
            }

            Value = value;
        }

        public string Value { get; }
    }

    public class LimitedString500 : LimitedString
    {
        public LimitedString500(string value)
            : base(value, 0, 500)
        {
        }
    }

    public class LimitedString20 : LimitedString
    {
        public LimitedString20(string value)
            : base(value, 0, 20)
        {
        }
    }

    public class LimitedString120 : LimitedString
    {
        public LimitedString120(string value)
            : base(value, 0, 120)
        {
        }
    }

    public class LimitedString1to60 : LimitedString
    {
        public LimitedString1to60(string value)
            : base(value, 1, 60)
        {
        }
    }

    public class Year
    {
        public Year(int value)
        {
            if (value >= 1000 && value <= 10000)
            {
                throw new ArgumentException($"Value is not valid year.");
            }

            Value = value;
        }

        public int Value { get; }
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
