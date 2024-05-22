using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.CargoJsonTypes
{
    public class Inventory
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        [JsonProperty("Stolen")]
        public long? Stolen { get; set; }

        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }
    }
}