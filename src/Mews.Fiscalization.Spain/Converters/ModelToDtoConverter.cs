using System;
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
        public SubmitIssuedInvoicesRequest Convert(InvoicesToSubmit model)
        {
            return new SubmitIssuedInvoicesRequest
            {
                Cabecera = Convert(model.Header),
                RegistroLRFacturasEmitidas = model.AddedInvoices.Select(i => Convert(i)).ToArray()
            };
        }

        public RemoveIssuedInvoiceRequest Convert(InvoicesToDelete model)
        {
            return new RemoveIssuedInvoiceRequest
            {
                Cabecera = Convert2(model.Header),
                RegistroLRBajaExpedidas = model.Invoices.Select(i => Convert(i)).ToArray()
            };
        }

        private LRfacturasEmitidasType Convert(AddedInvoice addedInvoice)
        {
            return new LRfacturasEmitidasType
            {
                PeriodoLiquidacion = Convert(addedInvoice.TaxPeriod),
                IDFactura = Convert(addedInvoice.Id),
                FacturaExpedida = new FacturaExpedidaType
                {
                    TipoFactura = Convert(addedInvoice.Type),
                    ClaveRegimenEspecialOTrascendencia = Convert(addedInvoice.SchemeOrEffect),
                    ImporteTotal = Convert(addedInvoice.TotalAmount),
                    DescripcionOperacion = addedInvoice.Description.Value,
                    Contraparte = Convert(addedInvoice.CounterParty),
                    TipoDesglose = Convert(addedInvoice.Breakdown)
                }
            };
        }

        private LRBajaExpedidasType Convert(Invoice invoice)
        {
            return new LRBajaExpedidasType
            {
                PeriodoLiquidacion = Convert(invoice.TaxPeriod),
                IDFactura = Convert2(invoice.Id)
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
            return counterParty?.Match(
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
                CodigoPais = foreignCompany.Country.Map(c => Convert(c)).GetOrElse(CountryType2.ES),
                CodigoPaisSpecified = foreignCompany.Country.NonEmpty,
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

        private IDFacturaExpedidaBCType Convert2(InvoiceId id)
        {
            return new IDFacturaExpedidaBCType
            {
                FechaExpedicionFacturaEmisor = Convert(id.Date),
                IDEmisorFactura = new IDFacturaExpedidaBCTypeIDEmisorFactura
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

        private CabeceraSiiBaja Convert2(Header header)
        {
            return new CabeceraSiiBaja
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
            var result = country.Alpha2Code.ToEnum<CountryType2>();
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
