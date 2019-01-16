namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString120 : LimitedString
    {
        public LimitedString120(string value)
            : base(value, 0, 120)
        {
        }
    }
}
