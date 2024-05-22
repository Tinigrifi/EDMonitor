using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Repair : LogEvent
    {
        [JsonProperty("Item")]
        public string Item { get; set; }

        [JsonProperty("Cost")]
        public int? Cost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Repair");
            sb.Append(" - Item: " + Item);
            sb.Append(" - Cost: " + ((int)Cost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Item);
                return sb.ToString();
            }
        }
    }
}