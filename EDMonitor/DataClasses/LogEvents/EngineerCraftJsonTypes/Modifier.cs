using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.EngineerCraftJsonTypes
{
    public class Modifier
    {
        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("Value")]
        public double? Value { get; set; }

        [JsonProperty("OriginalValue")]
        public double? OriginalValue { get; set; }

        [JsonProperty("LessIsGood")]
        public int? LessIsGood { get; set; }
    }
}