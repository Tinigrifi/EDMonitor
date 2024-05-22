using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class BuyExplorationData : LogEvent
    {
        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Cost")]
        public long? Cost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Buy Exploration Data - ");
            sb.Append("System: " + System);
            if (Cost != null)
            {
                sb.Append(" - Cost: ");
                sb.Append(((long)Cost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("System: " + System);
                return sb.ToString();
            }
        }
    }
}