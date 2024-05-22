using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MaterialDiscovered : LogEvent
    {
        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("DiscoveryNumber")]
        public long? DiscoveryNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Material (" + Category + "): ");
            sb.Append(string.IsNullOrWhiteSpace(NameLocalised) ? Name : NameLocalised);
            sb.Append(" Discovered");
            return sb.ToString();
        }
    }
}