﻿using System;
using System.Globalization;
using System.Linq;
using FuncSharp;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;
using Mews.Fiscalization.Spain.Dto.XSD.SuministroLR;
using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain
{
    public class ModelToDtoConverter
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
            CounterPartyCompany counterparty = invoice.Counterparty;
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
                    Contraparte = Convert(counterparty),
                    TipoDesglose = Convert(invoice.Breakdown)
                }
            };
        }

        private FacturaExpedidaTypeTipoDesglose Convert(BreakdownKind breakdown)
        {
            if (breakdown.OperationTypeBreakdown != null)
            {
                return new FacturaExpedidaTypeTipoDesglose
                {
                    Item = new TipoConDesgloseType
                    {
                        Entrega = new TipoSinDesgloseType
                        {
                            Sujeta = Convert(breakdown.OperationTypeBreakdown.Delivery.Item)
                        },
                        PrestacionServicios = new TipoSinDesglosePrestacionType
                        {
                            Sujeta = ConvertProvision(breakdown.OperationTypeBreakdown.ServiceProvision.Item)
                        }
                    }
                };
            }

            return new FacturaExpedidaTypeTipoDesglose
            {
                Item = new TipoSinDesgloseType
                {
                    Sujeta = Convert(breakdown.InvoiceBreakdown.Item)
                }
            };
        }

        private SujetaType Convert(Item item)
        {
            if (item.TaxFree != null)
            {
                return new SujetaType
                {
                    Exenta = item.TaxFree.Select(i => Convert(i)).ToArray()
                };
            }

            return new SujetaType
            {
                NoExenta = new SujetaTypeNoExenta
                {
                    TipoNoExenta = Convert(item.WithTax.TransactionType),
                    DesgloseIVA = item.WithTax.VatBreakdowns.Select(b => Convert(b)).ToArray()
                }
            };
        }

        private SujetaPrestacionType ConvertProvision(Item item)
        {
            if (item.TaxFree != null)
            {
                return new SujetaPrestacionType
                {
                    Exenta = item.TaxFree.Select(i => Convert(i)).ToArray()
                };
            }

            return new SujetaPrestacionType
            {
                NoExenta = new SujetaPrestacionTypeNoExenta
                {
                    TipoNoExenta = Convert(item.WithTax.TransactionType),
                    DesgloseIVA = item.WithTax.VatBreakdowns.Select(b => ConvertProvision(b)).ToArray()
                }
            };
        }

        private DetalleExentaType Convert(TaxFreeItem item)
        {
            return new DetalleExentaType
            {
                CausaExencion = item.Cause.Match(
                    CauseOfExemption.ExemptOnAccountOfArticle20, _ => CausaExencionType.E1,
                    CauseOfExemption.ExemptOnAccountOfArticle21, _ => CausaExencionType.E2,
                    CauseOfExemption.ExemptOnAccountOfArticle22, _ => CausaExencionType.E3,
                    CauseOfExemption.ExemptOnAccountOfArticle24, _ => CausaExencionType.E4,
                    CauseOfExemption.ExemptOnAccountOfArticle25, _ => CausaExencionType.E5,
                    CauseOfExemption.ExemptOnOtherGrounds, _ => CausaExencionType.E6
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
                TipoRecargoEquivalencia = Convert(breakdown.EquivalenceSurchargePercentage),
                CuotaRecargoEquivalencia = Convert(breakdown.EquivalenceSurchargeTaxAmount)
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

        private PersonaFisicaJuridicaType Convert(CounterPartyCompany counterparty)
        {
            if (counterparty.ForeignCompany != null)
            {
                return new PersonaFisicaJuridicaType
                {
                    NombreRazon = counterparty.ForeignCompany.Name.Value,
                    Item = Convert(counterparty.ForeignCompany)
                };
            }

            return new PersonaFisicaJuridicaType
            {
                NombreRazon = counterparty.CompanyTitle.Name.Value,
                Item = counterparty.CompanyTitle.TaxPayerNumber.Number
            };
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
                Ejercicio = taxPeriod.Year.ToString(),
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
                Titular = Convert(header.CompanyTitle)
            };
        }

        private PersonaFisicaJuridicaESType Convert(CompanyTitle companyTitle)
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
            throw new NotImplementedException();
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
    }
}