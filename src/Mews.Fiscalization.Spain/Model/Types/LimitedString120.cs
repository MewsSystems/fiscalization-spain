namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString120 : LimitedString
    {
        public LimitedString120(string value)
            : base(value, 0, 120)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, minLength: 0, maxLength: 120);
        }
    }
}
