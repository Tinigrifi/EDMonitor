using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.BountyJsonTypes
{
    public class BountyReward
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Reward")]
        public long? Reward { get; set; }
    }
}