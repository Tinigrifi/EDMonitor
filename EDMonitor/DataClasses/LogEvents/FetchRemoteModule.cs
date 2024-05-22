using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FetchRemoteModule : LogEvent
    {
        [JsonProperty("StorageSlot")]
        public int? StorageSlot { get; set; }

        [JsonProperty("StoredItem")]
        public string StoredItem { get; set; }

        [JsonProperty("StoredItem_Localised")]
        public string StoredItemLocalised { get; set; }

        [JsonProperty("ServerId")]
        public int? ServerId { get; set; }

        [JsonProperty("TransferCost")]
        public int? TransferCost { get; set; }

        [JsonProperty("TransferTime")]
        public int? TransferTime { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Fetch Remote Module");
            sb.Append(" - " + StoredItemLocalised ?? StoredItem);
            sb.Append(" - Transfer Cost: " + ((int)TransferCost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(StoredItemLocalised ?? StoredItem);
                return sb.ToString();
            }
        }
    }
}