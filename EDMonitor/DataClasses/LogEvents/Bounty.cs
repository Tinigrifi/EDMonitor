using EDMonitor.DataClasses.LogEvents.BountyJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Bounty : LogEvent
    {
        [JsonProperty("Rewards")]
        public List<BountyReward> Rewards { get; set; } = new List<BountyReward>();

        [JsonProperty("Target")]
        public string Target { get; set; }

        [JsonProperty("TotalReward")]
        public long? TotalReward { get; set; }

        [JsonProperty("VictimFaction")]
        public string VictimFaction { get; set; }

        [JsonProperty("SharedWithOthers")]
        public long? SharedWithOthers { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bounty - ");
            if (TotalReward != null)
            {
                sb.Append("Total Reward: ");
                sb.Append(((long)TotalReward).ToString("n0", CultureInfo.InvariantCulture) + " CR");
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