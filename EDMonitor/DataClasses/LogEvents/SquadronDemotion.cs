using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SquadronDemotion : LogEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        [JsonProperty("OldRank")]
        public int? OldRank { get; set; }

        [JsonProperty("NewRank")]
        public int? NewRank { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Squadron Demotion: ");
            sb.Append("Old Rank: " + OldRank.ToString());
            sb.Append(", New Rank: " + NewRank.ToString());
            return sb.ToString();
        }
    }
}