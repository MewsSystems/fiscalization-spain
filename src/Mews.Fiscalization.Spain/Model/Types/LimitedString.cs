using System;

namespace Mews.Fiscalization.Spain.Model
{
    public abstract class LimitedString
    {
        public LimitedString(string value, int minLength, int maxLength)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Max length of string is {maxLength}.");
            }

            if (value.Length < minLength)
            {
                throw new ArgumentException($"Min length of string is {minLength}.");
            }

            Value = value;
        }

        public string Value { get; }
    }
}
