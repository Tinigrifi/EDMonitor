using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.CargoTransferJsonTypes
{
    public class Transfer
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        [JsonProperty("Direction")]
        public string Direction { get; set; }
    }
}