using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.SynthesisJsonTypes
{
    public class Material
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }
    }
}