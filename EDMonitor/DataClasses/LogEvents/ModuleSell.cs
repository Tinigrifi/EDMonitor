using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ModuleSell : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("SellItem")]
        public string SellItem { get; set; }

        [JsonProperty("SellItem_Localised")]
        public string SellItemLocalised { get; set; }

        [JsonProperty("SellPrice")]
        public long? SellPrice { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long? ShipID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Module - Sell: ");
            sb.Append(string.IsNullOrEmpty(SellItemLocalised) ? SellItem : SellItemLocalised);
            sb.Append(" for " + Ship);
            sb.Append(" - Price: " + ((int)SellPrice).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(string.IsNullOrEmpty(SellItemLocalised) ? SellItem : SellItemLocalised);
                return sb.ToString();
            }
        }
    }
}