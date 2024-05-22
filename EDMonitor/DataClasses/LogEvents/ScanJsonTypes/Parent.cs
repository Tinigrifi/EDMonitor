using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.ScanJsonTypes
{
    public class Parent
    {
        [JsonProperty("Planet")]
        public long? Planet { get; set; }

        [JsonProperty("Star")]
        public long? Star { get; set; }

        [JsonProperty("Null")]
        public long? Null { get; set; }
    }
}