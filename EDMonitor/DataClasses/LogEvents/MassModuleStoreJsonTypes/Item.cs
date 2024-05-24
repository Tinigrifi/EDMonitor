using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MassModuleStoreJsonTypes
{
    public class Item
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Hot")]
        public bool? Hot { get; set; }

        [JsonProperty("Level")]
        public int? Level { get; set; }

        [JsonProperty("Quality")]
        public string Quality { get; set; }
    }
}