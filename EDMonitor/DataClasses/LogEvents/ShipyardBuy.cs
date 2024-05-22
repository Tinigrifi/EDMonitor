using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipyardBuy : LogEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("ShipPrice")]
        public int? ShipPrice { get; set; }

        [JsonProperty("StoreOldShip")]
        public string StoreOldShip { get; set; }

        [JsonProperty("StoreShipID")]
        public int? StoreShipID { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shipyard - Buy New");
            sb.Append(" " + ShipTypeLocalised ?? ShipType);
            sb.Append(" (" + ((int)ShipPrice).ToString("n0", CultureInfo.InvariantCulture) + " CR)");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ShipTypeLocalised ?? ShipType);
                return sb.ToString();
            }
        }
    }
}