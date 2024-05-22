using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class USSDrop : LogEvent
    {
        [JsonProperty("USSType")]
        public string USSType { get; set; }

        [JsonProperty("USSType_Localised")]
        public string USSTypeLocalised { get; set; }

        [JsonProperty("USSThreat")]
        public int? USSThreat { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("USS Drop - ");
            sb.Append(string.IsNullOrEmpty(USSTypeLocalised) ? USSType : USSTypeLocalised);
            if (USSThreat != null)
            {
                sb.Append(" (Thread " + USSThreat + ")");
            }
            return sb.ToString();
        }
    }
}