using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipyardSell : LogEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("SellShipID")]
        public long? SellShipID { get; set; }

        [JsonProperty("ShipPrice")]
        public long? ShipPrice { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shipyard - Sell");
            sb.Append(" " + ShipType);
            sb.Append(" (" + ((long)ShipPrice).ToString("n0", CultureInfo.InvariantCulture) + " CR)");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ShipType);
                return sb.ToString();
            }
        }
    }
}