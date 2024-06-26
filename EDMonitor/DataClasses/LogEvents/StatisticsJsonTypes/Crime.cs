﻿using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Crime
    {
        [JsonProperty("Fines")]
        public long? Fines { get; set; }

        [JsonProperty("Total_Fines")]
        public long? TotalFines { get; set; }

        [JsonProperty("Bounties_Received")]
        public long? BountiesReceived { get; set; }

        [JsonProperty("Total_Bounties")]
        public long? TotalBounties { get; set; }

        [JsonProperty("Highest_Bounty")]
        public long? HighestBounty { get; set; }
    }
}