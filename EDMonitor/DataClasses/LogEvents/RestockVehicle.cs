using EDMonitor.Business;
using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class RestockVehicle : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        [JsonProperty("Cost")]
        public long? Cost { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Restock " + Count.ToString() + " Vehicle" + (Count > 1 ? "s" : "") + " - " + Cost.ToString() + " CR");
            return sb.ToString();
        }
    }
}