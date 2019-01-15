using System;

namespace Mews.Fiscalization.Spain.Events
{
    public class HttpRequestFinishedEventArgs : EventArgs
    {
        public HttpRequestFinishedEventArgs(long duration)
        {
            Duration = duration;
        }

        public long Duration { get; }
    }
}
