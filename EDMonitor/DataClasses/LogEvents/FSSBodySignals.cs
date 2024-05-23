using EDMonitor.DataClasses.LogEvents.FSSAllBodySignalsJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FSSBodySignals : LogEvent
    {
        [JsonProperty("BodyName")]
        public string BodyName { get; set; }

        [JsonProperty("BodyID")]
        public long? BodyID { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("Signals")]
        public List<Signal> Signals { get; set; } = new List<Signal>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SSA Signals found on ");
            sb.Append(BodyName);
            sb.Append(" (");
            sb.Append(Signals.Count.ToString());
            sb.Append(" type" + (Signals.Count > 1 ? "s" : "") + ")");
            return sb.ToString();
        }
    }
}