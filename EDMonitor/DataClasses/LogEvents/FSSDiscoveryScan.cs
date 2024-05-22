using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FSSDiscoveryScan : LogEvent
    {
        [JsonProperty("Progress")]
        public double? Progress { get; set; }

        [JsonProperty("BodyCount")]
        public int? BodyCount { get; set; }

        [JsonProperty("NonBodyCount")]
        public int? NonBodyCount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FSS Discovery Scan: ");
            sb.Append(((double)Progress).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(" - " + BodyCount + " Bodies");
            sb.Append(", " + NonBodyCount + " non-Bodies");
            return sb.ToString();
        }
    }
}