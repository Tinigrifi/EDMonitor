using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipyardNew : LogEvent
    {
        [JsonProperty("ShipType")]
        public string ShipType { get; set; }

        [JsonProperty("ShipType_Localised")]
        public string ShipTypeLocalised { get; set; }

        [JsonProperty("NewShipID")]
        public int NewShipID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shipyard - New Ship:");
            sb.Append(" " + (string.IsNullOrEmpty(ShipTypeLocalised) ? ShipType : ShipTypeLocalised));
            return sb.ToString();
        }
    }
}