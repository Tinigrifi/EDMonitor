using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Crew
    {
        [JsonProperty("NpcCrew_TotalWages")]
        public long? NpcCrewTotalWages { get; set; }

        [JsonProperty("NpcCrew_Hired")]
        public long? NpcCrewHired { get; set; }

        [JsonProperty("NpcCrew_Fired")]
        public long? NpcCrewFired { get; set; }

        [JsonProperty("NpcCrew_Died")]
        public long? NpcCrewDied { get; set; }
    }
}