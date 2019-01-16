namespace Mews.Fiscalization.Spain.Model.Identifiers
{
    public class BillNumber : StringIdentifier
    {
        public BillNumber(string value)
            : base(value, Patterns.BillNumber)
        {
        }
    }
}
