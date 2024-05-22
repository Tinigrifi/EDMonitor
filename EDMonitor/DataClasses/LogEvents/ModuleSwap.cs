using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ModuleSwap : LogEvent
    {
        [JsonProperty("MarketID")]
        public long MarketID { get; set; }

        [JsonProperty("FromSlot")]
        public string FromSlot { get; set; }

        [JsonProperty("ToSlot")]
        public string ToSlot { get; set; }

        [JsonProperty("FromItem")]
        public string FromItem { get; set; }

        [JsonProperty("FromItem_Localised")]
        public string FromItemLocalised { get; set; }

        [JsonProperty("ToItem")]
        public string ToItem { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int ShipID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Module - Swap ");
            sb.Append("from " + (string.IsNullOrEmpty(FromItemLocalised) ? FromItem.Replace('_', ' ').Replace(" name", "") : FromItemLocalised.Replace('_', ' ').Replace(" name", "")));

            if (ToItem.StartsWith("$"))
            {
                ToItem = ToItem.Substring(1);
            }
            if (ToItem.EndsWith(";"))
            {
                ToItem = ToItem.Substring(0, ToItem.Length - 1);
            }
            sb.Append(" to " + ToItem.Replace('_', ' ').Replace(" name", ""));
            sb.Append(" - from " + FromSlot + " to " + ToSlot);
            return sb.ToString();
        }
    }
}