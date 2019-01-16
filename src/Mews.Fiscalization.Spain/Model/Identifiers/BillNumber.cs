namespace Mews.Fiscalization.Spain.Dto.Identifiers
{
    public class BillNumber : StringIdentifier
    {
        public BillNumber(string value)
            : base(value, Patterns.BillNumber)
        {
        }
    }
}
