using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SetUserShipName : LogEvent
    {
        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        [JsonProperty("UserShipName")]
        public string UserShipName { get; set; }

        [JsonProperty("UserShipId")]
        public string UserShipId { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Set User Ship Name");
            sb.Append(": " + UserShipName);
            sb.Append(" / " + UserShipId);
            return sb.ToString();
        }
    }
}