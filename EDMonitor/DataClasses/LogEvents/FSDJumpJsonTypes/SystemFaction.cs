using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.FSDJumpJsonTypes
{
    public class SystemFaction
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FactionState")]
        public string FactionState { get; set; }
    }
}