using System;

namespace Mews.Fiscalization.Spain.Model
{
    public class Amount
    {
        public Amount(decimal value)
        {
            var isValidAmount = value < 1000000000000 && value == Math.Round(value, 2);
            if (!isValidAmount)
            {
                throw new ArgumentException($"{nameof(value)} is not valid amount number.");
            }

            Value = value;
        }

        public decimal Value { get; }
    }
}
