using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CrewHire : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CrewID")]
        public long? CrewID { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Cost")]
        public int? Cost { get; set; }

        [JsonProperty("CombatRank")]
        public int? CombatRank { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crew: " + Name + " is hired for " + Cost.ToString() + ", Rank: " + CombatRank.ToString());
            return sb.ToString();
        }
    }
}
