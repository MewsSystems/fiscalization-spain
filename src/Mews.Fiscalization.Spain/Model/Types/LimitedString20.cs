namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString20 : LimitedString
    {
        public LimitedString20(string value)
            : base(value, 0, 20)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, minLength: 0, maxLength: 20);
        }
    }
}
