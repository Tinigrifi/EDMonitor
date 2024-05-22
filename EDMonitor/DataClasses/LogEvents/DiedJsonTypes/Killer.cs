using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.DiedJsonTypes
{
    public class Killer
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("Rank")]
        public string Rank { get; set; }
    }
}