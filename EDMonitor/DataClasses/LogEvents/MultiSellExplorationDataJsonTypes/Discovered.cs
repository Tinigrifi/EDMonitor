using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MultiSellExplorationDataJsonTypes
{
    public class Discovered
    {
        [JsonProperty("SystemName")]
        public string SystemName { get; set; }

        [JsonProperty("NumBodies")]
        public int? NumBodies { get; set; }
    }
}