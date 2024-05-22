using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ModuleBuy : LogEvent
    {
        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("BuyItem")]
        public string BuyItem { get; set; }

        [JsonProperty("BuyItem_Localised")]
        public string BuyItemLocalised { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("BuyPrice")]
        public int? BuyPrice { get; set; }

        [JsonProperty("SellPrice")]
        public int? SellPrice { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Module - Buy: ");
            sb.Append(BuyItemLocalised ?? BuyItem);
            sb.Append(" for " + Ship);
            sb.Append(" - Price: " + ((int)BuyPrice).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            if (SellPrice != null)
            {
                sb.Append(", Sell Price Old Module: " + ((int)SellPrice).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(BuyItemLocalised ?? BuyItem);
                return sb.ToString();
            }
        }
    }
}