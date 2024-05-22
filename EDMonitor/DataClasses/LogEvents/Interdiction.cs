using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Interdiction : LogEvent
    {
        [JsonProperty("Success")]
        public bool? Success { get; set; }

        [JsonProperty("Interdicted")]
        public string Interdicted { get; set; }

        [JsonProperty("IsPlayer")]
        public bool? IsPlayer { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("CombatRank")]
        public long? CombatRank { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Interdiction");
            if (Interdicted != null && string.IsNullOrEmpty(Interdicted))
            {
                sb.Append(" - Interdicted: " + Interdicted);
                sb.Append((IsPlayer != null && IsPlayer == true) ? " (Player)" : "");
            }
            if (Success != null && Success == true)
            {
                sb.Append(" => Success");
            }
            return sb.ToString();
        }
    }
}