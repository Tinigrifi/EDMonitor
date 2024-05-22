using Newtonsoft.Json;
using System;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class LogEvent
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("event")]
        public string EventType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(EventType);
            sb.Append(" >>>>>>>> NEED IMPLEMENTATION <<<<<<<<");
            return sb.ToString();
        }
    }
}