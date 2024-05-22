using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MissionCompletedJsonTypes
{
    public class Influence
    {
        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("Trend")]
        public string Trend { get; set; }

        [JsonProperty("Influence")]
        public string Name { get; set; }
    }
}