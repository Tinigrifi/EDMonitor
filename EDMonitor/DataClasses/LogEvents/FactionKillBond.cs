using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FactionKillBond : LogEvent
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
            sb.Append("Faction Kill Bond");
            sb.Append(" - Reward: " + ((long)Reward).ToString("n0", CultureInfo.InvariantCulture) + " CR");
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