using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Multicrew
    {
        [JsonProperty("Multicrew_Time_Total")]
        public long? MulticrewTimeTotal { get; set; }

        [JsonProperty("Multicrew_Gunner_Time_Total")]
        public long? MulticrewGunnerTimeTotal { get; set; }

        [JsonProperty("Multicrew_Fighter_Time_Total")]
        public long? MulticrewFighterTimeTotal { get; set; }

        [JsonProperty("Multicrew_Credits_Total")]
        public long? MulticrewCreditsTotal { get; set; }

        [JsonProperty("Multicrew_Fines_Total")]
        public long? MulticrewFinesTotal { get; set; }
    }
}