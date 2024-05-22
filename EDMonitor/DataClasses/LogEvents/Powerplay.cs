using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Powerplay : LogEvent
    {
        [JsonProperty("Power")]
        public string Power { get; set; }

        [JsonProperty("Rank")]
        public long? Rank { get; set; }

        [JsonProperty("Merits")]
        public long? Merits { get; set; }

        [JsonProperty("Votes")]
        public long? Votes { get; set; }

        [JsonProperty("TimePledged")]
        public long? TimePledged { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Powerplay: ");
            sb.Append(" " + Power);
            sb.Append(", Rank: " + Rank.ToString());
            sb.Append(", Merits: " + Merits.ToString());
            sb.Append(", Votes: " + Votes.ToString());
            return sb.ToString();
        }
    }
}