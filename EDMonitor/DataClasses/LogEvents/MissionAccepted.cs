using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MissionAccepted : LogEvent
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("LocalisedName")]
        public string LocalisedName { get; set; }

        [JsonProperty("TargetFaction")]
        public string TargetFaction { get; set; }

        [JsonProperty("DestinationSystem")]
        public string DestinationSystem { get; set; }

        [JsonProperty("DestinationStation")]
        public string DestinationStation { get; set; }

        [JsonProperty("Expiry")]
        public string Expiry { get; set; }

        [JsonProperty("Wing")]
        public bool? Wing { get; set; }

        [JsonProperty("Influence")]
        public string Influence { get; set; }

        [JsonProperty("Reputation")]
        public string Reputation { get; set; }

        [JsonProperty("Reward")]
        public int? Reward { get; set; }

        [JsonProperty("MissionID")]
        public int? MissionID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mission Accepted: ");
            sb.Append((string.IsNullOrEmpty(LocalisedName) ? Name : LocalisedName).Replace('_', ' ').Replace(" name", ""));
            if (Reward != null)
            {
                sb.Append(" - Reward: " + ((int)Reward).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }
    }
}