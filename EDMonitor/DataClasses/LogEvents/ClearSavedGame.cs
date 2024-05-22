using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ClearSavedGame : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("FID")]
        public string FID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Clear Saved Game - ");
            sb.Append(Name);
            sb .Append(" (" + FID + ")");
            return sb.ToString();
        }
    }
}