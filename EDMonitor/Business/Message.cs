using System;

namespace EDMonitor.Business
{
    public class Message
    {
        public DateTime Timestamp { get; set; }

        public string From { get; set; }

        public string Content { get; set; }
    }
}