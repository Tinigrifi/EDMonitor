using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Resurrect : LogEvent
    {
        [JsonProperty("Option")]
        public string Option { get; set; }

        [JsonProperty("Cost")]
        public int? Cost { get; set; }

        [JsonProperty("Bankrupt")]
        public bool? Bankrupt { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Resurrect");
            if (Cost != null && Cost > 0)
            {
                sb.Append(" - Cost: " + ((int)Cost).ToString("n0", CultureInfo.InvariantCulture));
                if (Bankrupt != null && Bankrupt == true)
                sb.Append(" (Bankrupt)");
            }
            return sb.ToString();
        }
    }
}