using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MissionCompletedJsonTypes
{
    public class Effect
    {
        [JsonProperty("Effect")]
        public string Name { get; set; }

        [JsonProperty("Effect_Localised")]
        public string EffectLocalised { get; set; }

        [JsonProperty("Trend")]
        public string Trend { get; set; }
    }
}