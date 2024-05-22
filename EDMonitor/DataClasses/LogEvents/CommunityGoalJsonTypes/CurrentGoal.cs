using Newtonsoft.Json;
using System.Collections.Generic;

namespace EDMonitor.DataClasses.LogEvents.CommunityGoalJsonTypes
{
    public class CurrentGoal
    {
        [JsonProperty("CGID")]
        public long? CGID { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("SystemName")]
        public string SystemName { get; set; }

        [JsonProperty("MarketName")]
        public string MarketName { get; set; }

        [JsonProperty("Expiry")]
        public string Expiry { get; set; }

        [JsonProperty("IsComplete")]
        public bool? IsComplete { get; set; }

        [JsonProperty("CurrentTotal")]
        public long? CurrentTotal { get; set; }

        [JsonProperty("PlayerContribution")]
        public long? PlayerContribution { get; set; }

        [JsonProperty("NumContributors")]
        public long? NumContributors { get; set; }

        [JsonProperty("TopRankSize")]
        public long? TopRankSize { get; set; }

        [JsonProperty("PlayerInTopRank")]
        public bool? PlayerInTopRank { get; set; }

        [JsonProperty("TierReached")]
        public string TierReached { get; set; }

        [JsonProperty("PlayerPercentileBand")]
        public long? PlayerPercentileBand { get; set; }

        [JsonProperty("Bonus")]
        public long? Bonus { get; set; }

        [JsonProperty("TopTier")]
        public List<TopTier> TopTier { get; set; } = new List<TopTier>();
    }
}