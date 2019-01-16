using System;

namespace Mews.Fiscalization.Spain.Model
{
    public class Percentage
    {
        public Percentage(decimal value)
        {
            var isValidPercentage = value >= 0 && value <= 100 && value == Math.Round(value, 2);
            if (!isValidPercentage)
            {
                throw new ArgumentException($"{nameof(value)} is not valid percentage number.");
            }

            Value = value;
        }

        public decimal Value { get; }
    }
}
