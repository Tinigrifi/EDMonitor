using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipyardTransfer : LogEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("ShipMarketID")]
        public long? ShipMarketID { get; set; }

        [JsonProperty("Distance")]
        public double? Distance { get; set; }

        [JsonProperty("TransferPrice")]
        public int? TransferPrice { get; set; }

        [JsonProperty("TransferTime")]
        public int? TransferTime { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shipyard - Transfer: ");
            sb.Append(ShipTypeLocalised ?? ShipType);
            sb.Append(" - Transfer Cost: " + ((int)TransferPrice).ToString("n0", CultureInfo.InvariantCulture) + " CR");
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