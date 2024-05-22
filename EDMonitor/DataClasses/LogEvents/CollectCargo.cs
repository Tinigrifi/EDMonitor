using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CollectCargo : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Stolen")]
        public bool? Stolen { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1 ");
            sb.Append(Type);
            sb.Append((Stolen != null && Stolen == true) ? " (Stolen)" : "");
            sb.Append(" Collected");
            return sb.ToString();
        }
    }
}