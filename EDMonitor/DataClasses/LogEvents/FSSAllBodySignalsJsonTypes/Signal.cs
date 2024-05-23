using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.FSSAllBodySignalsJsonTypes
{
    public class Signal
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }
    }
}