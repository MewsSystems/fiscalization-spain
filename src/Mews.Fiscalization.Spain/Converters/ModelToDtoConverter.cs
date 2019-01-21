using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FuncSharp;
using Mews.Fiscalization.Spain.Dto.Requests;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroLR;
using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain.Converters
{
    internal class ModelToDtoConverter
    {
        public SubmitIssuedInvoicesRequest Convert(InvoicesToRegister model)
        {
            return new SubmitIssuedInvoicesRequest
            {
                Cabecera = Convert(model.Header),
                RegistroLRFacturasEmitidas = model.Invoices.Select(i => Convert(i)).ToArray()
            };
        }

        private LRfacturasEmitidasType Convert(Invoice invoice)
        {
            return new LRfacturasEmitidasType
            {
                PeriodoLiquidacion = Convert(invoice.TaxPeriod),
                IDFactura = Convert(invoice.Id),
                FacturaExpedida = new FacturaExpedidaType
                {
                    TipoFactura = Convert(invoice.Type),
                    ClaveRegimenEspecialOTrascendencia = Convert(invoice.SchemeOrEffect),
                    ImporteTotal = Convert(invoice.TotalAmount),
                    DescripcionOperacion = invoice.Description.Value,
                    Contraparte = Convert(invoice.Counterparty),
                    TipoDesglose = Convert(invoice.Breakdown)
                }
            };
        }

        private FacturaExpedidaTypeTipoDesglose Convert(BreakdownItem breakdown)
        {
            return breakdown.Match(
                i => new FacturaExpedidaTypeTipoDesglose
                {
                    Item = new TipoSinDesgloseType
                    {
                        Sujeta = Convert(i)
                    }
                },
                o => new FacturaExpedidaTypeTipoDesglose
                {
                    Item = new TipoConDesgloseType
                    {
                        Entrega = new TipoSinDesgloseType
                        {
                            Sujeta = Convert(o.Delivery)
                        },
                        PrestacionServicios = new TipoSinDesglosePrestacionType
                        {
                            Sujeta = ConvertProvision(o.ServiceProvision)
                        }
                    }
                }
            );
        }

        private SujetaType Convert(InvoiceItem item)
        {
            return new SujetaType
            {
                Exenta = item.TaxFree.Map(f => f.Select(i => Convert(i)).ToArray()).GetOrNull(),
                NoExenta = item.WithTax.Map(t => new SujetaTypeNoExenta
                {
                    TipoNoExenta = Convert(t.TransactionType),
                    DesgloseIVA = t.VatBreakdowns.Select(b => Convert(b)).ToArray()
                }).GetOrNull()
            };
        }

        private SujetaPrestacionType ConvertProvision(InvoiceItem item)
        {
            return new SujetaPrestacionType
            {
                Exenta = item.TaxFree.Map(f => f.Select(i => Convert(i)).ToArray()).GetOrNull(),
                NoExenta = item.WithTax.Map(t => new SujetaPrestacionTypeNoExenta
                {
                    TipoNoExenta = Convert(t.TransactionType),
                    DesgloseIVA = t.VatBreakdowns.Select(b => ConvertProvision(b)).ToArray()
                }).GetOrNull()
            };
        }

        private DetalleExentaType Convert(TaxFreeItem item)
        {
            return new DetalleExentaType
            {
                CausaExencionSpecified = item.Cause.NonEmpty,
                CausaExencion = item.Cause.Match(
                    c => c.Match(
                        CauseOfExemption.Article20, _ => CausaExencionType.E1,
                        CauseOfExemption.Article21, _ => CausaExencionType.E2,
                        CauseOfExemption.Article22, _ => CausaExencionType.E3,
                        CauseOfExemption.Article24, _ => CausaExencionType.E4,
                        CauseOfExemption.Article25, _ => CausaExencionType.E5,
                        CauseOfExemption.OtherGrounds, _ => CausaExencionType.E6
                    ),
                    _ => (CausaExencionType?)null
                ),
                BaseImponible = Convert(item.Amount)
            };
        }

        private DetalleIVAEmitidaType Convert(VATBreakdown breakdown)
        {
            return new DetalleIVAEmitidaType
            {
                TipoImpositivo = Convert(breakdown.TaxRate),
                BaseImponible = Convert(breakdown.TaxBaseAmount),
                CuotaRepercutida = Convert(breakdown.TaxAmount),
                TipoRecargoEquivalencia = breakdown.EquivalenceSurchargePercentage.Map(p => Convert(p)).GetOrNull(),
                CuotaRecargoEquivalencia = breakdown.EquivalenceSurchargeTaxAmount.Map(a => Convert(a)).GetOrNull()
            };
        }

        private DetalleIVAEmitidaPrestacionType ConvertProvision(VATBreakdown breakdown)
        {
            return new DetalleIVAEmitidaPrestacionType
            {
                TipoImpositivo = Convert(breakdown.TaxRate),
                BaseImponible = Convert(breakdown.TaxBaseAmount),
                CuotaRepercutida = Convert(breakdown.TaxAmount)
            };
        }

        private PersonaFisicaJuridicaType Convert(CounterPartyCompany counterParty)
        {
            return counterParty.Match(
                t => new PersonaFisicaJuridicaType
                {
                    NombreRazon = t.Name.Value,
                    Item = t.TaxPayerNumber.Number
                },
                c => new PersonaFisicaJuridicaType
                {
                    NombreRazon = c.Name.Value,
                    Item = Convert(c)
                }
            );
        }

        private IDOtroType Convert(ForeignCompany foreignCompany)
        {
            return new IDOtroType
            {
                CodigoPais = Convert(foreignCompany.Country),
                ID = foreignCompany.Id.Value,
                IDType = foreignCompany.IdentificatorType.Match(
                    ResidenceCountryIdentificatorType.NifVat, _ => PersonaFisicaJuridicaIDTypeType.Item02,
                    ResidenceCountryIdentificatorType.Passport, _ => PersonaFisicaJuridicaIDTypeType.Item03,
                    ResidenceCountryIdentificatorType.OfficialIdentificationDocumentIssuedByTheCountry, _ => PersonaFisicaJuridicaIDTypeType.Item04,
                    ResidenceCountryIdentificatorType.ResidenceCertificate, _ => PersonaFisicaJuridicaIDTypeType.Item05,
                    ResidenceCountryIdentificatorType.OtherSupportingDocument, _ => PersonaFisicaJuridicaIDTypeType.Item06,
                    ResidenceCountryIdentificatorType.NotSelected, _ => PersonaFisicaJuridicaIDTypeType.Item07
                )
            };
        }

        private RegistroSiiPeriodoLiquidacion Convert(TaxPeriod taxPeriod)
        {
            return new RegistroSiiPeriodoLiquidacion
            {
                Ejercicio = Convert(taxPeriod.Year),
                Periodo = taxPeriod.Month.Match(
                    Month.January, _ => TimePeriodType.January,
                    Month.February, _ => TimePeriodType.January,
                    Month.March, _ => TimePeriodType.January,
                    Month.April, _ => TimePeriodType.January,
                    Month.May, _ => TimePeriodType.January,
                    Month.June, _ => TimePeriodType.January,
                    Month.July, _ => TimePeriodType.January,
                    Month.August, _ => TimePeriodType.January,
                    Month.September, _ => TimePeriodType.January,
                    Month.October, _ => TimePeriodType.January,
                    Month.November, _ => TimePeriodType.January,
                    Month.December, _ => TimePeriodType.December
                )
            };
        }

        private IDFacturaExpedidaType Convert(InvoiceId id)
        {
            return new IDFacturaExpedidaType
            {
                FechaExpedicionFacturaEmisor = Convert(id.Date),
                IDEmisorFactura = new IDFacturaExpedidaTypeIDEmisorFactura
                {
                    NIF = id.Issuer.Number
                },
                NumSerieFacturaEmisor = id.Number.Value
            };
        }

        private CabeceraSii Convert(Header header)
        {
            return new CabeceraSii
            {
                IDVersionSii = VersionSiiType.Item11,
                Titular = Convert(header.Company)
            };
        }

        private PersonaFisicaJuridicaESType Convert(LocalCompany companyTitle)
        {
            return new PersonaFisicaJuridicaESType
            {
                NombreRazon = companyTitle.Name.Value,
                NIF = companyTitle.TaxPayerNumber.Number
            };
        }

        private ClaveTipoFacturaType Convert(InvoiceType type)
        {
            return type.Match(
                InvoiceType.Invoice, _ => ClaveTipoFacturaType.F1,
                InvoiceType.SimplifiedInvoice, _ => ClaveTipoFacturaType.F2,
                InvoiceType.CorrectedInvoice, _ => ClaveTipoFacturaType.R1,
                InvoiceType.CorrectedInvoice2, _ => ClaveTipoFacturaType.R2,
                InvoiceType.CorrectedInvoice3, _ => ClaveTipoFacturaType.R3,
                InvoiceType.CorrectedInvoice4, _ => ClaveTipoFacturaType.R4,
                InvoiceType.CorrectedInvoiceInSimplifiedInvoices, _ => ClaveTipoFacturaType.R5,
                InvoiceType.InvoiceIssuedToReplaceSimplifiedInvoices, _ => ClaveTipoFacturaType.F3,
                InvoiceType.InvoiceSummaryEntry, _ => ClaveTipoFacturaType.F4
            );
        }

        private IdOperacionesTrascendenciaTributariaType Convert(SchemeOrEffect schemeOrEffect)
        {
            return schemeOrEffect.Match(
                SchemeOrEffect.GeneralTaxRegimeActivity, _ => IdOperacionesTrascendenciaTributariaType.Item01,
                SchemeOrEffect.Export, _ => IdOperacionesTrascendenciaTributariaType.Item02,
                SchemeOrEffect.WorksOfArt, _ => IdOperacionesTrascendenciaTributariaType.Item03,
                SchemeOrEffect.InvestmentGold, _ => IdOperacionesTrascendenciaTributariaType.Item04,
                SchemeOrEffect.TravelAgencies, _ => IdOperacionesTrascendenciaTributariaType.Item05,
                SchemeOrEffect.GroupsOfEntities, _ => IdOperacionesTrascendenciaTributariaType.Item06,
                SchemeOrEffect.CashBasis, _ => IdOperacionesTrascendenciaTributariaType.Item07,
                SchemeOrEffect.CanaryIslandsGeneralIndirectTax, _ => IdOperacionesTrascendenciaTributariaType.Item08,
                SchemeOrEffect.TravelAgencyServicesActingAsIntermediaries, _ => IdOperacionesTrascendenciaTributariaType.Item09,
                SchemeOrEffect.Collections, _ => IdOperacionesTrascendenciaTributariaType.Item10,
                SchemeOrEffect.BusinessPremisesLeaseActivities1, _ => IdOperacionesTrascendenciaTributariaType.Item11,
                SchemeOrEffect.BusinessPremisesLeaseActivities2, _ => IdOperacionesTrascendenciaTributariaType.Item12,
                SchemeOrEffect.BusinessPremisesLeaseActivities3, _ => IdOperacionesTrascendenciaTributariaType.Item13,
                SchemeOrEffect.InvoiceWithVATPendingAccrual1, _ => IdOperacionesTrascendenciaTributariaType.Item14,
                SchemeOrEffect.InvoiceWithVATPendingAccrual2, _ => IdOperacionesTrascendenciaTributariaType.Item15
            );
        }

        private TipoOperacionSujetaNoExentaType Convert(TransactionType transactionType)
        {
            return transactionType.Match(
                TransactionType.NotExempt, _ => TipoOperacionSujetaNoExentaType.S1,
                TransactionType.InvTaxablePerson, _ => TipoOperacionSujetaNoExentaType.S2,
                TransactionType.NotExemptWithPassiveSubject, _ => TipoOperacionSujetaNoExentaType.S3
            );
        }

        private CountryType2 Convert(Country country)
        {
            var codes = new Dictionary<Country, string>
            {
               { Country.Andorra, "AD" },
               { Country.UnitedArabEmirates, "AE" },
               { Country.Afghanistan, "AF" },
               { Country.AntiguaandBarbuda, "AG" },
               { Country.Anguilla, "AI" },
               { Country.Albania, "AL" },
               { Country.Armenia, "AM" },
               { Country.Angola, "AO" },
               { Country.Antarctica, "AQ" },
               { Country.Argentina, "AR" },
               { Country.AmericanSamoa, "AS" },
               { Country.Austria, "AT" },
               { Country.Australia, "AU" },
               { Country.Aruba, "AW" },
               { Country.Azerbaijan, "AZ" },
               { Country.BosniaandHerzegovina, "BA" },
               { Country.Barbados, "BB" },
               { Country.Bangladesh, "BD" },
               { Country.Belgium, "BE" },
               { Country.BurkinaFaso, "BF" },
               { Country.Bulgaria, "BG" },
               { Country.Bahrain, "BH" },
               { Country.Burundi, "BI" },
               { Country.Benin, "BJ" },
               { Country.Bermuda, "BM" },
               { Country.BruneiDarussalam, "BN" },
               { Country.Bolivia, "BO" },
               { Country.Bonaire, "BQ" },
               { Country.Brazil, "BR" },
               { Country.Bahamas, "BS" },
               { Country.Bhutan, "BT" },
               { Country.BouvetIsland, "BV" },
               { Country.Botswana, "BW" },
               { Country.Belarus, "BY" },
               { Country.Belize, "BZ" },
               { Country.Canada, "CA" },
               { Country.CocosKeelingIslands, "CC" },
               { Country.DemocraticRepublicOfTheCongo, "CD" },
               { Country.CentralAfricanRepublic, "CF" },
               { Country.RepublicOfTheCongo, "CG" },
               { Country.Switzerland, "CH" },
               { Country.IvoryCoast, "CI" },
               { Country.CookIslands, "CK" },
               { Country.Chile, "CL" },
               { Country.Cameroon, "CM" },
               { Country.China, "CN" },
               { Country.Colombia, "CO" },
               { Country.CostaRica, "CR" },
               { Country.Cuba, "CU" },
               { Country.CaboVerde, "CV" },
               { Country.Curaçao, "CW" },
               { Country.ChristmasIsland, "CX" },
               { Country.Cyprus, "CY" },
               { Country.Czechia, "CZ" },
               { Country.Germany, "DE" },
               { Country.Djibouti, "DJ" },
               { Country.Denmark, "DK" },
               { Country.Dominica, "DM" },
               { Country.DominicanRepublic, "DO" },
               { Country.Algeria, "DZ" },
               { Country.Ecuador, "EC" },
               { Country.Estonia, "EE" },
               { Country.Egypt, "EG" },
               { Country.Eritrea, "ER" },
               { Country.Spain, "ES" },
               { Country.Ethiopia, "ET" },
               { Country.Finland, "FI" },
               { Country.Fiji, "FJ" },
               { Country.FalklandIslands, "FK" },
               { Country.Micronesia, "FM" },
               { Country.FaroeIslands, "FO" },
               { Country.France, "FR" },
               { Country.Gabon, "GA" },
               { Country.UnitedKingdomofGreatBritainandNorthernIreland, "GB" },
               { Country.Grenada, "GD" },
               { Country.Georgia, "GE" },
               { Country.Guernsey, "GG" },
               { Country.Ghana, "GH" },
               { Country.Gibraltar, "GI" },
               { Country.Greenland, "GL" },
               { Country.Gambia, "GM" },
               { Country.Guinea, "GN" },
               { Country.EquatorialGuinea, "GQ" },
               { Country.Greece, "GR" },
               { Country.SouthGeorgiaandtheSouthSandwichIslands, "GS" },
               { Country.Guatemala, "GT" },
               { Country.Guam, "GU" },
               { Country.GuineaBissau, "GW" },
               { Country.Guyana, "GY" },
               { Country.HongKong, "HK" },
               { Country.HeardIslandandMcDonaldIslands, "HM" },
               { Country.Honduras, "HN" },
               { Country.Croatia, "HR" },
               { Country.Haiti, "HT" },
               { Country.Hungary, "HU" },
               { Country.Indonesia, "ID" },
               { Country.Ireland, "IE" },
               { Country.Israel, "IL" },
               { Country.IsleofMan, "IM" },
               { Country.India, "IN" },
               { Country.BritishIndianOceanTerritory, "IO" },
               { Country.Iraq, "IQ" },
               { Country.Iran, "IR" },
               { Country.Iceland, "IS" },
               { Country.Italy, "IT" },
               { Country.Jersey, "JE" },
               { Country.Jamaica, "JM" },
               { Country.Jordan, "JO" },
               { Country.Japan, "JP" },
               { Country.Kenya, "KE" },
               { Country.Kyrgyzstan, "KG" },
               { Country.Cambodia, "KH" },
               { Country.Kiribati, "KI" },
               { Country.Comoros, "KM" },
               { Country.SaintKittsandNevis, "KN" },
               { Country.NorthKorea, "KP" },
               { Country.SouthKorea, "KR" },
               { Country.Kuwait, "KW" },
               { Country.CaymanIslands, "KY" },
               { Country.Kazakhstan, "KZ" },
               { Country.Laos, "LA" },
               { Country.Lebanon, "LB" },
               { Country.SaintLucia, "LC" },
               { Country.Liechtenstein, "LI" },
               { Country.SriLanka, "LK" },
               { Country.Liberia, "LR" },
               { Country.Lesotho, "LS" },
               { Country.Lithuania, "LT" },
               { Country.Luxembourg, "LU" },
               { Country.Latvia, "LV" },
               { Country.Libya, "LY" },
               { Country.Morocco, "MA" },
               { Country.Monaco, "MC" },
               { Country.Moldova, "MD" },
               { Country.Montenegro, "ME" },
               { Country.Madagascar, "MG" },
               { Country.MarshallIslands, "MH" },
               { Country.Macedonia, "MK" },
               { Country.Mali, "ML" },
               { Country.Myanmar, "MM" },
               { Country.Mongolia, "MN" },
               { Country.Macao, "MO" },
               { Country.NorthernMarianaIslands, "MP" },
               { Country.Mauritania, "MR" },
               { Country.Montserrat, "MS" },
               { Country.Malta, "MT" },
               { Country.Mauritius, "MU" },
               { Country.Maldives, "MV" },
               { Country.Malawi, "MW" },
               { Country.Mexico, "MX" },
               { Country.Malaysia, "MY" },
               { Country.Mozambique, "MZ" },
               { Country.Namibia, "NA" },
               { Country.NewCaledonia, "NC" },
               { Country.Niger, "NE" },
               { Country.NorfolkIsland, "NF" },
               { Country.Nigeria, "NG" },
               { Country.Nicaragua, "NI" },
               { Country.Netherlands, "NL" },
               { Country.Norway, "NO" },
               { Country.Nepal, "NP" },
               { Country.Nauru, "NR" },
               { Country.Niue, "NU" },
               { Country.NewZealand, "NZ" },
               { Country.Oman, "OM" },
               { Country.Panama, "PA" },
               { Country.Peru, "PE" },
               { Country.FrenchPolynesia, "PF" },
               { Country.PapuaNewGuinea, "PG" },
               { Country.Philippines, "PH" },
               { Country.Pakistan, "PK" },
               { Country.Poland, "PL" },
               { Country.SaintPierreandMiquelon, "PM" },
               { Country.Pitcairn, "PN" },
               { Country.PuertoRico, "PR" },
               { Country.Palestine, "PS" },
               { Country.Portugal, "PT" },
               { Country.Palau, "PW" },
               { Country.Paraguay, "PY" },
               { Country.Qatar, "QA" },
               { Country.Romania, "RO" },
               { Country.Serbia, "RS" },
               { Country.RussianFederation, "RU" },
               { Country.Rwanda, "RW" },
               { Country.SaudiArabia, "SA" },
               { Country.SolomonIslands, "SB" },
               { Country.Seychelles, "SC" },
               { Country.Sudan, "SD" },
               { Country.Sweden, "SE" },
               { Country.Singapore, "SG" },
               { Country.SaintHelena, "SH" },
               { Country.Slovenia, "SI" },
               { Country.Slovakia, "SK" },
               { Country.SierraLeone, "SL" },
               { Country.SanMarino, "SM" },
               { Country.Senegal, "SN" },
               { Country.Somalia, "SO" },
               { Country.Suriname, "SR" },
               { Country.SouthSudan, "SS" },
               { Country.SaoTomeandPrincipe, "ST" },
               { Country.ElSalvador, "SV" },
               { Country.SintMaartenDutchpart, "SX" },
               { Country.SyrianArabRepublic, "SY" },
               { Country.Eswatini, "SZ" },
               { Country.TurksandCaicosIslands, "TC" },
               { Country.Chad, "TD" },
               { Country.FrenchSouthernTerritories, "TF" },
               { Country.Togo, "TG" },
               { Country.Thailand, "TH" },
               { Country.Tajikistan, "TJ" },
               { Country.Tokelau, "TK" },
               { Country.TimorLeste, "TL" },
               { Country.Turkmenistan, "TM" },
               { Country.Tunisia, "TN" },
               { Country.Tonga, "TO" },
               { Country.Turkey, "TR" },
               { Country.TrinidadandTobago, "TT" },
               { Country.Tuvalu, "TV" },
               { Country.Taiwan, "TW" },
               { Country.Tanzania, "TZ" },
               { Country.Ukraine, "UA" },
               { Country.Uganda, "UG" },
               { Country.UnitedStatesMinorOutlyingIslands, "UM" },
               { Country.UnitedStatesofAmerica, "US" },
               { Country.Uruguay, "UY" },
               { Country.Uzbekistan, "UZ" },
               { Country.HolySee, "VA" },
               { Country.SaintVincentandtheGrenadines, "VC" },
               { Country.Venezuela, "VE" },
               { Country.VirginIslandsBritish, "VG" },
               { Country.VirginIslandsUS, "VI" },
               { Country.VietNam, "VN" },
               { Country.Vanuatu, "VU" },
               { Country.WallisandFutuna, "WF" },
               { Country.Samoa, "WS" },
               { Country.Yemen, "YE" },
               { Country.Mayotte, "YT" },
               { Country.SouthAfrica, "ZA" },
               { Country.Zambia, "ZM" },
               { Country.Zimbabwe, "ZW" }
            };

            var result = codes.Get(country).FlatMap(c => c.ToEnum<CountryType2>());
            return result.Get();
        }

        private string Convert(Amount totalAmount)
        {
            return totalAmount.Value.ToString(CultureInfo.InvariantCulture);
        }

        private string Convert(Percentage percentage)
        {
            return percentage.Value.ToString(CultureInfo.InvariantCulture);
        }

        private string Convert(DateTime date)
        {
            return date.ToString("dd-MM-yyyy");
        }

        private string Convert(Year year)
        {
            return year.Value.ToString();
        }
    }
}
