using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.FSDJumpJsonTypes
{
    public class ActiveState
    {
        [JsonProperty("State")]
        public string State { get; set; }
    }
}