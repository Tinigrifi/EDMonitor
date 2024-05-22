using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.LocationJsonTypes
{
    public class ActiveState
    {
        [JsonProperty("State")]
        public string State { get; set; }
    }
}