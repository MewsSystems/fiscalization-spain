using Mews.Fiscalization.Spain.Dto.XSD.SuministroInformacion;

namespace Mews.Fiscalization.Spain.Environment
{
    public static class Credentials
    {
        public static CabeceraSii GeneratorCabecera => new CabeceraSii
        {
            IDVersionSii = VersionSiiType.Item11,
            TipoComunicacion = ClaveTipoComunicacionType.A0,
            Titular = GeneratorCompany
        };

        public static PersonaFisicaJuridicaESType GeneratorCompany => new PersonaFisicaJuridicaESType
        {
            NIF = GeneratorNIF,
            NombreRazon = GeneratorNombreRazon
        };

        public static PersonaFisicaJuridicaType MicrosoftCompany => new PersonaFisicaJuridicaType("A08433179", "Microsoft test company");

        public static string GeneratorNIF => "B65374811";
        public static string GeneratorNombreRazon => "GENERATOR BCN 1, S.L.";
    }
}
