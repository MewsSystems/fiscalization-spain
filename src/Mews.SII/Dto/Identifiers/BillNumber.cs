namespace Mews.Sii.Dto.Identifiers
{
    public class BillNumber : StringIdentifier
    {
        public BillNumber(string value)
            : base(value, Patterns.BillNumber)
        {
        }
    }
}
