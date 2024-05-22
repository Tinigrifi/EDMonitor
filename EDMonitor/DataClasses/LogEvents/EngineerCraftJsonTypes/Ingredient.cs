using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.EngineerCraftJsonTypes
{
    public class Ingredient
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }
    }
}