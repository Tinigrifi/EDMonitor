using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.CommunityGoalJsonTypes
{
    public class TopTier
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Bonus")]
        public string Bonus { get; set; }
    }
}