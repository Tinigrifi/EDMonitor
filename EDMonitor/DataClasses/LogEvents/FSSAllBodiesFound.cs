using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FSSAllBodiesFound : LogEvent
    {
        [JsonProperty("SystemName")]
        public string SystemName { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("Count")]
        public int Count { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FSS All Bodies Found");
            sb.Append(" (" + Count.ToString() + ")");
            return sb.ToString();
        }
    }
}