using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Reputation : LogEvent
    {
        [JsonProperty("Empire")]
        public double? Empire { get; set; }

        [JsonProperty("Federation")]
        public double? Federation { get; set; }

        [JsonProperty("Independant")]
        public double? Independant { get; set; }

        [JsonProperty("Alliance")]
        public double? Alliance { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reputation");
            sb.Append(" - Empire: " + (Empire / 100 ?? 0).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", Federation: " + (Federation / 100 ?? 0).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", Alliance: " + (Alliance / 100 ?? 0).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", Independant: " + (Independant / 100 ?? 0).ToString("P", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}