using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SquadronStartup : LogEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        [JsonProperty("CurrentRank")]
        public int? CurrentRank { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Squadron Startup");
            sb.Append(" - Current Rank: " + CurrentRank.ToString());
            return sb.ToString();
        }
    }
}