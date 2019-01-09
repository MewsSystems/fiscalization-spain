using System;

namespace Mews.Sii
{
    public class DateTimeProvider
    {
        public static DateTimeWithTimeZone Now
        {
            get { return new DateTimeWithTimeZone(DateTime.UtcNow, TimeZoneInfo.Utc); }
        }
    }
}
