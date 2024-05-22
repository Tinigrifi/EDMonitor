using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SellExplorationData : LogEvent
    {
        [JsonProperty("Systems")]
        public List<string> Systems { get; set; } = new List<string>();

        [JsonProperty("Discovered")]
        public List<string> Discovered { get; set; } = new List<string>();

        [JsonProperty("BaseValue")]
        public long? BaseValue { get; set; }

        [JsonProperty("Bonus")]
        public long? Bonus { get; set; }

        [JsonProperty("TotalEarnings")]
        public long? TotalEarnings { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sell Exploration Data");
            sb.Append(" - TotalEarnings: " + ((int)TotalEarnings).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            sb.Append(" (" + ((int)BaseValue).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            sb.Append(" + " + ((int)Bonus).ToString("n0", CultureInfo.InvariantCulture) + " CR)");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Discovered.Count.ToString() + " Discoveries");
                return sb.ToString();
            }
        }
    }
}