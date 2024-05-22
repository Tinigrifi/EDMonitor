using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MissionAbandoned : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MissionID")]
        public int MissionID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mission Abandoned: ");
            sb.Append(Name.Replace('_', ' ').Replace(" name", ""));
            return sb.ToString();
        }
    }
}