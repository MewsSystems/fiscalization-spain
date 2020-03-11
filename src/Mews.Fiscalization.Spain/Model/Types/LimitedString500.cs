namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString500 : LimitedString
    {
        public LimitedString500(string value)
            : base(value, 0, 500)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, minLength: 0, maxLength: 500);
        }
    }
}
