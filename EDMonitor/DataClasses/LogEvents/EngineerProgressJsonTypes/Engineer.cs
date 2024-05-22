using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.EngineerProgressJsonTypes
{
    public class Engineer
    {
        [JsonProperty("Engineer")]
        public string Name { get; set; }

        [JsonProperty("EngineerID")]
        public int? EngineerID { get; set; }

        [JsonProperty("Progress")]
        public string Progress { get; set; }

        [JsonProperty("RankProgress")]
        public int? RankProgress { get; set; }

        [JsonProperty("Rank")]
        public int? Rank { get; set; }
    }
}