namespace Mews.Fiscalization.Spain.Model
{
    public class LimitedString1to20 : LimitedString
    {
        public LimitedString1to20(string value)
            : base(value, 1, 20)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, minLength: 1, maxLength: 20);
        }
    }
}
