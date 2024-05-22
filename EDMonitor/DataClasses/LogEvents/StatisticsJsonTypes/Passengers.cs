using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Passengers
    {
        [JsonProperty("Passengers_Missions_Accepted")]
        public long? Passengers_Missions_Accepted { get; set; }

        [JsonProperty("Passengers_Missions_Disgruntled")]
        public long? Passengers_Missions_Disgruntled { get; set; }

        [JsonProperty("Passengers_Missions_Bulk")]
        public long? PassengersMissionsBulk { get; set; }

        [JsonProperty("Passengers_Missions_VIP")]
        public long? PassengersMissionsVIP { get; set; }

        [JsonProperty("Passengers_Missions_Delivered")]
        public long? PassengersMissionsDelivered { get; set; }

        [JsonProperty("Passengers_Missions_Ejected")]
        public long? PassengersMissionsEjected { get; set; }
    }
}