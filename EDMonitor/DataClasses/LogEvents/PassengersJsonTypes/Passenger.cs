using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.PassengersJsonTypes
{
    public class Passenger
    {
        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("VIP")]
        public bool? VIP { get; set; }

        [JsonProperty("Wanted")]
        public bool? Wanted { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }
    }
}