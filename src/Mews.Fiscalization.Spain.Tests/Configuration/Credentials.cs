using Mews.Fiscalization.Spain.Model;

namespace Mews.Fiscalization.Spain.Tests.Configuration
{
    public static class Credentials
    {
        public static LocalCompany GeneratorCompany => new LocalCompany(
            new LimitedString120("GENERATOR BCN 1, S.L."),
            new TaxPayerNumber("B65374811")
        );

        public static LocalCompany MicrosoftCompany => new LocalCompany(
            new LimitedString120("Microsoft test company"),
            new TaxPayerNumber("A08433179")
        );
    }
}
