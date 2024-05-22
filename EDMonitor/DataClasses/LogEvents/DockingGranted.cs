using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DockingGranted : LogEvent
    {
        [JsonProperty("LandingPad")]
        public int? LandingPad { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("StationType")]
        public string StationType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Docking Granted:");
            sb.Append(" Go to Pad [[ " + ((int)LandingPad).ToString().PadLeft(2, '0') + " ]]");
            return sb.ToString();
        }
    }
}