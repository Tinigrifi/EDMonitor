using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.LocationJsonTypes
{
    public class PendingState
    {
        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Trend")]
        public long? Trend { get; set; }
    }
}