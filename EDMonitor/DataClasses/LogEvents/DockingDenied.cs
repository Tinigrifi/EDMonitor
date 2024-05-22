using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DockingDenied : LogEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StationType")]
        public string StationType { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Reason")]
        public string Reason { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Docking Denied");
            return sb.ToString();
        }
    }
}