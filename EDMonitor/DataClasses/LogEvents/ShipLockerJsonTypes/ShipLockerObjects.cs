using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.ShipLockerJsonTypes
{
    public class ShipLockerObject
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("OwnerID")]
        public long? OwnerID { get; set; }

        [JsonProperty("MissionID ")]
        public long? MissionID { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }
    }
}
