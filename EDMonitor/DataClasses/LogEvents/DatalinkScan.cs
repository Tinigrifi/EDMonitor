using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DatalinkScan : LogEvent
    {
        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Datalink Scan - ");
            sb.Append(string.IsNullOrEmpty(MessageLocalised) ? Message : MessageLocalised);
            return sb.ToString();
        }
    }
}