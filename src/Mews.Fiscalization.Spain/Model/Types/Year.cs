using System;

namespace Mews.Fiscalization.Spain.Model
{
    public class Year
    {
        public Year(int value)
        {
            var isValidYear = value >= 1000 && value <= 10000;
            if (!isValidYear)
            {
                throw new ArgumentException($"Value is not valid year.");
            }

            Value = value;
        }

        public int Value { get; }
    }
}
