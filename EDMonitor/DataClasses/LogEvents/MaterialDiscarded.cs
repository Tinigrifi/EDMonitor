using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MaterialDiscarded : LogEvent
    {
        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Name_Localised")]
        public string NameLocalised { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Material (" + Category + "): ");
            sb.Append(Count.ToString() + " " + (string.IsNullOrWhiteSpace(NameLocalised) ? Name : NameLocalised));
            sb.Append(" Discarded");
            return sb.ToString();
        }
    }
}