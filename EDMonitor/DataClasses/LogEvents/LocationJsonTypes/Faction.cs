using Newtonsoft.Json;
using System.Collections.Generic;
using EDMonitor.DataClasses.LogEvents.LocationJsonTypes;

namespace EDMonitor.DataClasses.LogEvents.LocationJsonTypes
{
    public class Faction
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FactionState")]
        public string FactionState { get; set; }

        [JsonProperty("Government")]
        public string Government { get; set; }

        [JsonProperty("Influence")]
        public double? Influence { get; set; }

        [JsonProperty("Allegiance")]
        public string Allegiance { get; set; }

        [JsonProperty("PendingStates")]
        public List<PendingState> PendingStates { get; set; } = new List<PendingState>();

        [JsonProperty("RecoveringStates")]
        public List<RecoveringState> RecoveringStates { get; set; } = new List<RecoveringState>();

        [JsonProperty("Happiness_Localised")]
        public string HappinessLocalised { get; set; }

        [JsonProperty("MyReputation")]
        public double MyReputation { get; set; }

        [JsonProperty("ActiveStates")]
        public List<ActiveState> ActiveStates { get; set; } = new List<ActiveState>();
    }
}