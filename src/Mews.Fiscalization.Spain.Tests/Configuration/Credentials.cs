using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain.Tests.Configuration
{
    public static class Credentials
    {
        public static CompanyTitle GeneratorCompany => new CompanyTitle(
            new LimitedString120("GENERATOR BCN 1, S.L."),
            new TaxPayerNumber("B65374811")
        );

        public static CompanyTitle MicrosoftCompany => new CompanyTitle(
            new LimitedString120("Microsoft test company"),
            new TaxPayerNumber("A08433179")
        );
    }
}
