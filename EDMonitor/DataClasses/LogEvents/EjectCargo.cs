using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class EjectCargo : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        [JsonProperty("Abandoned")]
        public bool? Abandoned { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Eject Cargo");
            sb.Append(" - " + (string.IsNullOrEmpty(TypeLocalised) ? Type : TypeLocalised));
            sb.Append(" (" + Count.ToString() + ")");
            if (Abandoned != null && Abandoned == true)
            {
                sb.Append(" - Abandonned");
            }
            return sb.ToString();
        }
    }
}