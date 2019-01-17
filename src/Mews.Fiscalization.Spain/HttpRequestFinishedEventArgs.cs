using System;

namespace Mews.Fiscalization.Spain
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
