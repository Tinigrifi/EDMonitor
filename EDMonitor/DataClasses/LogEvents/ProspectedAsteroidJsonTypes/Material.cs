using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.ProspectedAsteroidJsonTypes
{
    public class Material
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Proportion")]
        public double? Proportion { get; set; }
    }
}