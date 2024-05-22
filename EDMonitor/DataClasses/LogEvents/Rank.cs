using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Rank : LogEvent
    {
        [JsonProperty("Combat")]
        public int? Combat { get; set; }

        [JsonProperty("Trade")]
        public int? Trade { get; set; }

        [JsonProperty("Explore")]
        public int? Explore { get; set; }

        [JsonProperty("Empire")]
        public int? Empire { get; set; }

        [JsonProperty("Federation")]
        public int? Federation { get; set; }

        [JsonProperty("CQC")]
        public int? CQC { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ranks");
            sb.Append(" - Combat:" + Combat.ToString());
            sb.Append(", Trade:" + Trade.ToString());
            sb.Append(", Explore:" + Explore.ToString());
            sb.Append(", CQC:" + CQC.ToString());
            sb.Append(" / Empire:" + Empire.ToString());
            sb.Append(", Federation:" + Federation.ToString());
            return sb.ToString();
        }
    }
}