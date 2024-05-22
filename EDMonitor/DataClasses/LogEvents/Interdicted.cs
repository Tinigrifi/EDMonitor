using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Interdicted : LogEvent
    {
        [JsonProperty("Submitted")]
        public bool? Submitted { get; set; }

        [JsonProperty("Interdictor")]
        public string Interdictor { get; set; }

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
            sb.Append("Interdicted - ");
            sb.Append("Interdictor: " + Interdictor);
            sb.Append((IsPlayer != null && IsPlayer == true) ? " (Player)" : "");
            if (Submitted != null && Submitted == true)
            {
                sb.Append(" => Submitted");
            }
            return sb.ToString();
        }
    }
}