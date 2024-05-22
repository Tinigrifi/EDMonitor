using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.ScanJsonTypes
{
    public class Composition
    {
        [JsonProperty("Ice")]
        public double? Ice { get; set; }

        [JsonProperty("Rock")]
        public double? Rock { get; set; }

        [JsonProperty("Metal")]
        public double? Metal { get; set; }
    }
}