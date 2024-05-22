using Newtonsoft.Json;
using System.Collections.Generic;

namespace EDMonitor.DataClasses.LogEvents.MissionCompletedJsonTypes
{
    public class FactionEffect
    {
        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Effects")]
        public List<Effect> Effects { get; set; } = new List<Effect>();

        [JsonProperty("Influence")]
        public List<Influence> Influence { get; set; } = new List<Influence>();

        [JsonProperty("ReputationTrend")]
        public string ReputationTrend { get; set; }

        [JsonProperty("Reputation")]
        public string Reputation { get; set; }
    }
}