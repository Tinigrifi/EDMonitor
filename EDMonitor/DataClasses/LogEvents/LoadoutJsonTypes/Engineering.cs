using Newtonsoft.Json;
using System.Collections.Generic;

namespace EDMonitor.DataClasses.LogEvents.LoadoutJsonTypes
{
    public class Engineering
    {
        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("EngineerID")]
        public long? EngineerID { get; set; }

        [JsonProperty("BlueprintName")]
        public string BlueprintName { get; set; }

        [JsonProperty("BlueprintID")]
        public long? BlueprintID { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("Quality")]
        public double? Quality { get; set; }

        [JsonProperty("ExperimentalEffect")]
        public string ExperimentalEffect { get; set; }

        [JsonProperty("Modifiers")]
        public List<Modifier> Modifiers { get; set; } = new List<Modifier>();
    }
}