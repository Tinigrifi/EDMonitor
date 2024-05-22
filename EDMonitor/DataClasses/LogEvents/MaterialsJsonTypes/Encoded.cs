using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MaterialsJsonTypes
{
    public class Encoded
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }
    }
}