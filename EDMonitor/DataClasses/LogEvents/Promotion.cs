using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Promotion : LogEvent
    {
        [JsonProperty("Combat")]
        public int? Combat { get; set; }

        [JsonProperty("Trade")]
        public int? Trade { get; set; }

        [JsonProperty("Explore")]
        public int? Explore { get; set; }

        [JsonProperty("CQC")]
        public int? CQC { get; set; }

        [JsonProperty("Federation")]
        public int? Federation { get; set; }

        [JsonProperty("Empire")]
        public int? Empire { get; set; }

        [JsonProperty("Alliance")]
        public int? Alliance { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Promotion in");
            if (Combat != null)
            {
                sb.Append(" Combat - New Rank: " + Combat.ToString());
            }
            if (Trade != null)
            {
                sb.Append(" Trade - New RankK: " + Trade.ToString());
            }
            if (Explore != null)
            {
                sb.Append(" Explore - New Rank: " + Explore.ToString());
            }
            if (CQC != null)
            {
                sb.Append(" CQC - New Rank: " + CQC.ToString());
            }
            if (Federation != null)
            {
                sb.Append(" Federation - New Rank: " + Federation.ToString());
            }
            if (Empire != null)
            {
                sb.Append(" Empire - New Rank: " + Empire.ToString());
            }
            if (Alliance != null)
            {
                sb.Append(" Alliance - New Rank: " + Alliance.ToString());
            }
            return sb.ToString();
        }
    }
}