using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.ScanJsonTypes
{
    public class Ring
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("RingClass")]
        public string RingClass { get; set; }

        [JsonProperty("MassMT")]
        public double? MassMT { get; set; }

        [JsonProperty("InnerRad")]
        public double? InnerRad { get; set; }

        [JsonProperty("OuterRad")]
        public double? OuterRad { get; set; }
    }
}