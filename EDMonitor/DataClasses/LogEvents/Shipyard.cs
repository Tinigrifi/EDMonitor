using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Shipyard : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shipyard in");
            sb.Append(" " + StationName);
            sb.Append(" / " + StarSystem);
            return sb.ToString();
        }
    }
}