using System;
using System.Xml;

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

        public static bool IsValid(string value)
        {
            try
            {
                XmlConvert.VerifyXmlChars(value);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }

        protected static bool IsValid(string value, int minLength, int maxLength)
        {
            return value != null && value.Length <= maxLength && value.Length >= minLength;
        }
    }
}
