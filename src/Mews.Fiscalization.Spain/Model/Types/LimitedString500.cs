namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString500 : LimitedString
    {
        public LimitedString500(string value)
            : base(value, 0, 500)
        {
        }
    }
}
