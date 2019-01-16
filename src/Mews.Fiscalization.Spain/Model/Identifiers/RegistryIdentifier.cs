namespace Mews.Fiscalization.Spain.Model.Identifiers
{
    public class RegistryIdentifier : StringIdentifier
    {
        public RegistryIdentifier(string value)
            : base(value, Patterns.RegistryIdentifier)
        {
        }
    }
}
