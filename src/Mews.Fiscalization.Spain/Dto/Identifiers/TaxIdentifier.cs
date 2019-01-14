namespace Mews.Fiscalization.Spain.Dto.Identifiers
{
    public class TaxIdentifier : StringIdentifier
    {
        public TaxIdentifier(string value)
            : base(value, Patterns.TaxIdentifier)
        {
        }
    }
}
