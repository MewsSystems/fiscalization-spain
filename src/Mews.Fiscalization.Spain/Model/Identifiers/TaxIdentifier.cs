namespace Mews.Fiscalization.Spain.Model.Identifiers
{
    public class TaxIdentifier : StringIdentifier
    {
        public TaxIdentifier(string value)
            : base(value, Patterns.TaxIdentifier)
        {
        }
    }
}
