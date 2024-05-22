using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class NewCommander : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FID")]
        public string FID { get; set; }

        [JsonProperty("Package")]
        public string Package { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("New Commander: ");
            sb.Append(Name);
            sb.Append(" (" + FID + ")");
            sb.Append(" / Package:");
            sb.Append(" " + Package);
            return sb.ToString();
        }
    }
}