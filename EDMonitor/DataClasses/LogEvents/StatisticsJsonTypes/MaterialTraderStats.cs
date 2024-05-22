using Newtonsoft.Json;

namespace EDMonitor.DataClasses.LogEvents.StatisticsJsonTypes
{
    public class MaterialTraderStats
    {
        [JsonProperty("Trades_Completed")]
        public long? TradesCompleted { get; set; }

        [JsonProperty("Materials_Traded")]
        public long? MaterialsTraded { get; set; }

        [JsonProperty("Encoded_Materials_Traded")]
        public long? EncodedMaterialsTraded { get; set; }

        [JsonProperty("Raw_Materials_Traded")]
        public long? RawMaterialsTraded { get; set; }

        [JsonProperty("Grade_1_Materials_Traded")]
        public long? Grade1MaterialsTraded { get; set; }

        [JsonProperty("Grade_2_Materials_Traded")]
        public long? Grade2MaterialsTraded { get; set; }

        [JsonProperty("Grade_3_Materials_Traded")]
        public long? Grade3MaterialsTraded { get; set; }

        [JsonProperty("Grade_4_Materials_Traded")]
        public long? Grade4MaterialsTraded { get; set; }

        [JsonProperty("Grade_5_Materials_Traded")]
        public long? Grade5MaterialsTraded { get; set; }
    }
}