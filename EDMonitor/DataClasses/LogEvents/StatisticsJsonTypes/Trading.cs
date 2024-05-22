using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Trading
    {
        [JsonProperty("Markets_Traded_With")]
        public long? MarketsTradedWith { get; set; }

        [JsonProperty("Market_Profits")]
        public long? MarketProfits { get; set; }

        [JsonProperty("Resources_Traded")]
        public long? ResourcesTraded { get; set; }

        [JsonProperty("Average_Profit")]
        public long? AverageProfit { get; set; }

        [JsonProperty("Highest_Single_Transaction")]
        public long? HighestSingleTransaction { get; set; }
    }
}