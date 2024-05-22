using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class Mining
    {
        [JsonProperty("Mining_Profits")]
        public long? MiningProfits { get; set; }

        [JsonProperty("Quantity_Mined")]
        public long? QuantityMined { get; set; }

        [JsonProperty("Materials_Collected")]
        public long? MaterialsCollected { get; set; }
    }
}