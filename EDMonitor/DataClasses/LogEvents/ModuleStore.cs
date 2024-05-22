using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ModuleStore : LogEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("Slot")]
        public string Slot { get; set; }

        [JsonProperty("StoredItem")]
        public string StoredItem { get; set; }

        [JsonProperty("StoredItem_Localised")]
        public string StoredItemLocalised { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int ShipID { get; set; }

        [JsonProperty("Hot")]
        public bool Hot { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Module - Store: ");
            sb.Append(string.IsNullOrEmpty(StoredItemLocalised) ? StoredItem : StoredItemLocalised);
            return sb.ToString();
        }
    }
}