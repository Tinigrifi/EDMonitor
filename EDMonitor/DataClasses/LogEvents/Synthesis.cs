
using EDMonitor.DataClasses.LogEvents.SynthesisJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Synthesis : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Materials")]
        public List<Material> Materials { get; set; } = new List<Material>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Synthesis: ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}