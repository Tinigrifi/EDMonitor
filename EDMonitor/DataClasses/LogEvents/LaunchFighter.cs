using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class LaunchFighter : LogEvent
    {
        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        [JsonProperty("ID")]
        public long? ID { get; set; }

        [JsonProperty("PlayerControlled")]
        public bool? PlayerControlled { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Launch Fighter");
            return sb.ToString();
        }
    }
}