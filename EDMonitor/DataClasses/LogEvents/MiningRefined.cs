using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MiningRefined : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Type_Localised")]
        public string TypeLocalised { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mining Refined: ");
            sb.Append("1 " + ((string.IsNullOrEmpty(TypeLocalised)) ? Type : TypeLocalised));
            return sb.ToString();
        }
    }
}