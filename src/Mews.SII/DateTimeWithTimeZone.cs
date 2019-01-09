using System;

namespace Mews.Sii
{
    public class DateTimeWithTimeZone
    {
        public DateTimeWithTimeZone(DateTime dateTime, TimeZoneInfo timezoneInfo)
        {
            DateTime = dateTime;
            TimeZoneInfo = timezoneInfo;
        }

        public DateTime DateTime { get; }

        public TimeZoneInfo TimeZoneInfo { get; }
    }
}