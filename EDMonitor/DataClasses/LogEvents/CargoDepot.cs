using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CargoDepot : LogEvent
    {
        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }

        [JsonProperty("UpdateType")]
        public string UpdateType { get; set; }

        [JsonProperty("CargoType")]
        public string CargoType { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        [JsonProperty("StartMarketID")]
        public long? StartMarketID { get; set; }

        [JsonProperty("EndMarketID")]
        public long? EndMarketID { get; set; }

        [JsonProperty("ItemsCollected")]
        public long? ItemsCollected { get; set; }

        [JsonProperty("ItemsDelivered")]
        public long? ItemsDelivered { get; set; }

        [JsonProperty("TotalItemsToDeliver")]
        public long? TotalItemsToDeliver { get; set; }

        [JsonProperty("Progress")]
        public double? Progress { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Count != null)
            {
                sb.Append("Cargo Depot - ");
                sb.Append("Type: " + CargoType);
                sb.Append(", Count: " + Count);
                sb.Append(", Items Delivered: " + ItemsDelivered + "/" + TotalItemsToDeliver);
            }
            else
            {
                sb.Append("Cargo Depot");
            }
            return sb.ToString();
        }
    }
}