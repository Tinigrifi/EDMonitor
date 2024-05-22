using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MarketSell : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        [JsonProperty("SellPrice")]
        public long? SellPrice { get; set; }

        [JsonProperty("TotalSale")]
        public long? TotalSale { get; set; }

        [JsonProperty("AvgPricePaid")]
        public long? AvgPricePaid { get; set; }

        [JsonProperty("IllegalGoods")]
        public bool? IllegalGoods { get; set; }

        [JsonProperty("StolenGoods")]
        public bool? StolenGoods { get; set; }

        [JsonProperty("BlackMarket")]
        public bool? BlackMarket { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((BlackMarket != null && BlackMarket == true) ? "Black " : "");
            sb.Append("Market - Sell ");
            sb.Append(Count + " " + (string.IsNullOrEmpty(TypeLocalised) ? Type : TypeLocalised));
            sb.Append((StolenGoods != null && StolenGoods == true) ? " (StolenGoods)" : "");
            sb.Append((IllegalGoods != null && IllegalGoods == true) ? " (IllegalGoods)" : "");
            sb.Append(" - Total Sale: " + ((int)TotalSale).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Count + " " + (string.IsNullOrEmpty(TypeLocalised) ? Type : TypeLocalised));
                sb.Append((StolenGoods != null && StolenGoods == true) ? " (StolenGoods)" : "");
                sb.Append((IllegalGoods != null && IllegalGoods == true) ? " (IllegalGoods)" : "");
                return sb.ToString();
            }
        }
    }
}