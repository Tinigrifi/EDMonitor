using EDMonitor.DataClasses.LogEvents.MaterialsJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Materials : LogEvent
    {
        [JsonProperty("Raw")]
        public List<Raw> Raw { get; set; } = new List<Raw>();

        [JsonProperty("Manufactured")]
        public List<Manufactured> Manufactured { get; set; } = new List<Manufactured>();

        [JsonProperty("Encoded")]
        public List<Encoded> Encoded { get; set; } = new List<Encoded>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Materials");
            sb.Append(" - Raw: " + Raw.Count);
            sb.Append(", Manufactured: " + Manufactured.Count);
            sb.Append(", Encoded: " + Encoded.Count);
            return sb.ToString();
        }
    }
}