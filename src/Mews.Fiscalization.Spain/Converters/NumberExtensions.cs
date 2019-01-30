namespace Mews.Fiscalization.Spain.Converters
{
    internal static class NumberExtensions
    {
        internal static string Serialize(this decimal value)
        {
            return value.ToString("{0:0.00}");
        }
    }
}
