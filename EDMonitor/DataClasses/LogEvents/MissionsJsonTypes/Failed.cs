﻿using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.MissionsJsonTypes
{
    public class Failed
    {
        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("PassengerMission")]
        public bool? PassengerMission { get; set; }

        [JsonProperty("Expires")]
        public long? Expires { get; set; }
    }
}