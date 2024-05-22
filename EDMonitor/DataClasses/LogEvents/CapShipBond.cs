using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CapShipBond : LogEvent
    {
        [JsonProperty("Reward")]
        public long? Reward { get; set; }

        [JsonProperty("AwardingFaction")]
        public string AwardingFaction { get; set; }

        [JsonProperty("VictimFaction")]
        public string VictimFaction { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cap Ship Bond - ");
            sb.Append("Awarding Faction: " + AwardingFaction);
            sb.Append(", Victim Faction: " + VictimFaction);
            if (Reward != null)
            {
                sb.Append(" - Reward: " + ((int)Reward).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Victim Faction: " + VictimFaction);
                return sb.ToString();
            }
        }
    }
}