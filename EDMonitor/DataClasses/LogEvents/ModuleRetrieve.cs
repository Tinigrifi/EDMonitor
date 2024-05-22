using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ModuleRetrieve : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("RetrievedItem")]
        public string RetrievedItem { get; set; }

        [JsonProperty("RetrievedItem_Localised")]
        public string RetrievedItemLocalised { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        [JsonProperty("Hot")]
        public bool? Hot { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Module - Retrieve: ");
            sb.Append(string.IsNullOrEmpty(RetrievedItemLocalised) ? RetrievedItem : RetrievedItemLocalised);
            sb.Append(" for " + Ship);
            return sb.ToString();
        }
    }
}