using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.LoadoutJsonTypes
{
    public class Module
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("Item")]
        public string Item { get; set; }

        [JsonProperty("On")]
        public bool? On { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }

        [JsonProperty("Health")]
        public double? Health { get; set; }

        [JsonProperty("Value")]
        public long? Value { get; set; }

        [JsonProperty("AmmoInClip")]
        public long? AmmoInClip { get; set; }

        [JsonProperty("AmmoInHopper")]
        public long? AmmoInHopper { get; set; }

        [JsonProperty("Engineering")]
        public Engineering Engineering { get; set; }
    }
}