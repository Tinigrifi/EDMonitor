using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CommitCrime : LogEvent
    {
        [JsonProperty("CrimeType")]
        public string CrimeType { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Fine")]
        public int? Fine { get; set; }

        [JsonProperty("Bounty")]
        public int? Bounty { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Commit Crime");
            sb.Append(" - Faction: " + Faction);
            if (Fine != null)
            {
                sb.Append(" - Fine: ");
                sb.Append(((int)Fine).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            if (Bounty != null)
            {
                sb.Append(" - Bounty: ");
                sb.Append(((int)Bounty).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }
    }
}