using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class TaxPeriod
    {
        public TaxPeriod(Year year, Month month)
        {
            Year = year ?? throw new ArgumentNullException(nameof(year));
            Month = month;
        }

        public Year Year { get; }

        public Month Month { get; }
    }
}
