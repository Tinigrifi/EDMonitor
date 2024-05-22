using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class EngineerContribution : LogEvent
    {
        [JsonProperty("Engineer")]
        public string Engineer { get; set; }

        [JsonProperty("EngineerID")]
        public int? EngineerID { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Commodity")]
        public string Commodity { get; set; }

        [JsonProperty("Quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("TotalQuantity")]
        public int? TotalQuantity { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Engineer ");
            sb.Append(Engineer);
            sb.Append(" - Contribution: " + TotalQuantity.ToString() + " " + Commodity);
            return sb.ToString();
        }
    }
}