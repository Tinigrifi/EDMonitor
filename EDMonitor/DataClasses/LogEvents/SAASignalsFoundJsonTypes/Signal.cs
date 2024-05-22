using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.SAASignalsFoundJsonTypes
{
    public class Signal
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }
    }
}