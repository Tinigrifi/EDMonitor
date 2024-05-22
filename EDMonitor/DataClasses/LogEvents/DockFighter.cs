using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DockFighter : LogEvent
    {
        [JsonProperty("ID")]
        public int? ID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dock Fighter");
            return sb.ToString();
        }
    }
}