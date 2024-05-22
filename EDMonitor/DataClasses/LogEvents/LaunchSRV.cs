using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class LaunchSRV : LogEvent
    {
        [JsonProperty("Loadout")]
        public string Loadout { get; set; }

        [JsonProperty("PlayerControlled")]
        public bool? PlayerControlled { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Launch SRV");
            sb.Append((PlayerControlled != null && PlayerControlled == true) ? " - Player Controlled" : "");
            return sb.ToString();
        }
    }
}