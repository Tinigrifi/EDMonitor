using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DiscoveryScan : LogEvent
    {
        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("Bodies")]
        public long? Bodies { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Discovery Scan - ");
            sb.Append(Bodies + "Bodies");
            return sb.ToString();
        }
    }
}