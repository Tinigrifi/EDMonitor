using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class SearchAndRescue
    {
        [JsonProperty("SearchRescue_Traded")]
        public long? SearchRescueTraded { get; set; }

        [JsonProperty("SearchRescue_Profit")]
        public long? SearchRescueProfit { get; set; }

        [JsonProperty("SearchRescue_Count")]
        public long? SearchRescueCount { get; set; }
    }
}