using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.LocationJsonTypes
{
    public class StationFaction
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FactionState")]
        public string FactionState { get; set; }
    }
}