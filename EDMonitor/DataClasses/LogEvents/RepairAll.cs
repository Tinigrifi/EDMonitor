using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class RepairAll : LogEvent
    {
        [JsonProperty("Cost")]
        public int? Cost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Repair All");
            sb.Append(" - Cost: " + ((int)Cost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }
    }
}