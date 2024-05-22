using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DataScanned : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DataScanned - ");
            sb.Append(string.IsNullOrEmpty(TypeLocalised) ? Type : TypeLocalised);
            return sb.ToString();
        }
    }
}