using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MarketBuy : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        [JsonProperty("BuyPrice")]
        public long? BuyPrice { get; set; }

        [JsonProperty("TotalCost")]
        public long? TotalCost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Market - Buy ");
            sb.Append(Count + " " + TypeLocalised ?? Type);
            sb.Append(" - Total Cost: " + ((int)TotalCost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Count + " " + TypeLocalised ?? Type);
                return sb.ToString();
            }
        }
    }
}