using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MaterialsJsonTypes
{
    public class Raw
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }
    }
}