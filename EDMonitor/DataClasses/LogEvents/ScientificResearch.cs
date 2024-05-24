using EDMonitor.Business;
using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ScientificResearch : LogEvent
    {
        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Count")]
        public int? Count { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Scientific Research " + Count.ToString() + " " + Name + " (" + Category + ")");
            return sb.ToString();
        }
    }
}