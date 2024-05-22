using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class LaunchDrone : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Launch Drone " + Type);
            return sb.ToString();
        }
    }
}