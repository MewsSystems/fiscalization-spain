using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain.Tests.Configuration
{
    public static class Credentials
    {
        public static readonly string IssuerTaxNumber = System.Environment.GetEnvironmentVariable("issuer_tax_number") ?? "INSERT_ISSUER_TAX_NUMBER";
        public static readonly string ReceiverTaxNumber = System.Environment.GetEnvironmentVariable("receiver_tax_number") ?? "INSERT_RECEIVER_TAX_NUMBER";

        public static LocalCompany TestCompany1 => new LocalCompany(
            new LimitedString120("Test company 1"),
            new TaxPayerNumber(IssuerTaxNumber)
        );

        public static LocalCompany TestCompany2 => new LocalCompany(
            new LimitedString120("Test company 2"),
            new TaxPayerNumber(ReceiverTaxNumber)
        );
    }
}
