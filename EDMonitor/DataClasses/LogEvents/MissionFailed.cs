using EDMonitor.Business;
using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MissionFailed : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("MissionID")]
        public long? MissionID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mission " + Name + " failed");
            return sb.ToString();
        }
    }
}