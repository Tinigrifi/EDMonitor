using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents
{
    public class PVPKill : LogEvent
    {
        [JsonProperty("Victim")]
        public string Victim { get; set; }

        [JsonProperty("CombatRank")]
        public long? CombatRank { get; set; }
    }
}