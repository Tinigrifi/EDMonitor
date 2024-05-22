using EDMonitor.DataClasses.LogEvents.MultiSellExplorationDataJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MultiSellExplorationData : LogEvent
    {
        [JsonProperty("Discovered")]
        public List<Discovered> Discovered { get; set; } = new List<Discovered>();

        [JsonProperty("BaseValue")]
        public int? BaseValue { get; set; }

        [JsonProperty("Bonus")]
        public int? Bonus { get; set; }

        [JsonProperty("TotalEarnings")]
        public int? TotalEarnings { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Multi Sell Exploration Data");
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