using EDMonitor.DataClasses.LogEvents.SAASignalsFoundJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SAASignalsFound : LogEvent
    {
        [JsonProperty("BodyName")]
        public string BodyName { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("BodyID")]
        public int? BodyID { get; set; }

        [JsonProperty("Signals")]
        public List<Signal> Signals { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SAA Signals Found");
            sb.Append(" - " + BodyName);
            sb.Append(" - " + Signals.Count + " signals found");
            return sb.ToString();
        }
    }
}