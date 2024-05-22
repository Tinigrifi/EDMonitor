using Newtonsoft.Json;
using EDMonitor.DataClasses.LogEvents.MaterialTradeJsonTypes;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MaterialTrade : LogEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("TraderType")]
        public string TraderType { get; set; }

        [JsonProperty("Paid")]
        public Paid Paid { get; set; }

        [JsonProperty("Received")]
        public Received Received { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Material Trade");
            sb.Append(" - Paid: ");
            sb.Append(string.IsNullOrEmpty(Paid.MaterialLocalised) ? Paid.Material : Paid.MaterialLocalised);
            sb.Append(" ×" + Paid.Quantity);
            sb.Append(" - Received: ");
            sb.Append(string.IsNullOrEmpty(Received.MaterialLocalised) ? Received.Material : Received.MaterialLocalised);
            sb.Append(" ×" + Received.Quantity);
            return sb.ToString();
        }
    }
}