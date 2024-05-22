using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class RefuelAll : LogEvent
    {
        [JsonProperty("Cost")]
        public int? Cost { get; set; }

        [JsonProperty("Amount")]
        public double? Amount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Refuel All");
            sb.Append(" - Amount: " + ((double)Amount).ToString("n3", CultureInfo.InvariantCulture) + " T");
            sb.Append(" - Cost: " + ((int)Cost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }
    }
}