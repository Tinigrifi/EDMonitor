using EDMonitor.DataClasses.LogEvents.MissionCompletedJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MissionCompleted : LogEvent
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MissionID")]
        public int? MissionID { get; set; }

        [JsonProperty("Commodity")]
        public string Commodity { get; set; }

        [JsonProperty("Commodity_Localised")]
        public string CommodityLocalised { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }

        [JsonProperty("TargetFaction")]
        public string TargetFaction { get; set; }

        [JsonProperty("DestinationSystem")]
        public string DestinationSystem { get; set; }

        [JsonProperty("DestinationStation")]
        public string DestinationStation { get; set; }

        [JsonProperty("Reward")]
        public int? Reward { get; set; }

        [JsonProperty("Donation")]
        public int? Donation { get; set; }

        [JsonProperty("Donated")]
        public int? Donated { get; set; }

        [JsonProperty("FactionEffects")]
        public List<FactionEffect> FactionEffects { get; set; } = new List<FactionEffect>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mission Completed: ");
            sb.Append(Name.Replace('_', ' ').Replace(" name", ""));
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
                sb.Append(Name.Replace('_', ' ').Replace(" name", ""));
                return sb.ToString();
            }
        }
    }
}