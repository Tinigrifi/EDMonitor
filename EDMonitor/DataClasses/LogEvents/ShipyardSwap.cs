using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipyardSwap : LogEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        [JsonProperty("StoreOldShip")]
        public string StoreOldShip { get; set; }

        [JsonProperty("StoreShipID")]
        public int? StoreShipID { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shipyard - Swap");
            sb.Append(": " + StoreOldShip);
            sb.Append(" for " + (string.IsNullOrEmpty(ShipTypeLocalised) ? ShipType : ShipTypeLocalised));
            return sb.ToString();
        }
    }
}