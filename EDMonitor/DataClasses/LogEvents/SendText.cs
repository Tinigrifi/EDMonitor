using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SendText : LogEvent
    {
        [JsonProperty("To")]
        public string To { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Send Text");
            sb.Append(" to " + To);
            sb.Append(": " + Message);
            return sb.ToString();
        }
    }
}