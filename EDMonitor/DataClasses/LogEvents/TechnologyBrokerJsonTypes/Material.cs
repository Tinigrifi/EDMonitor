using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.TechnologyBrokerJsonTypes
{
    public class Material
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }
    }
}