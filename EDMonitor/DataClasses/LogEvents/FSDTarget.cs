using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FSDTarget : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FSD Target");
            sb.Append(": " + Name);
            return sb.ToString();
        }
    }
}