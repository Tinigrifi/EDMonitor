using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SAAScanComplete : LogEvent
    {
        [JsonProperty("BodyName")]
        public string BodyName { get; set; }

        [JsonProperty("BodyID")]
        public int? BodyID { get; set; }

        [JsonProperty("ProbesUsed")]
        public int? ProbesUsed { get; set; }

        [JsonProperty("EfficiencyTarget")]
        public int? EfficiencyTarget { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SAA Scan Complete");
            sb.Append(" - " + BodyName);
            sb.Append(" (probes: " + ProbesUsed.ToString() + "/" + EfficiencyTarget.ToString() + ")");
            return sb.ToString();
        }
    }
}