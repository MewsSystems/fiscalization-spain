using System;

namespace Mews.Fiscalization.Spain
{
    public class DateTimeProvider
    {
        public static DateTimeWithTimeZone Now
        {
            get { return new DateTimeWithTimeZone(DateTime.UtcNow, TimeZoneInfo.Utc); }
        }
    }
}
