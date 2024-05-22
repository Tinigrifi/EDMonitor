using EDMonitor.DataClasses.LogEvents.MissionsJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Missions : LogEvent
    {
        [JsonProperty("Active")]
        public List<Active> Active { get; set; } = new List<Active>();

        [JsonProperty("Failed")]
        public List<Failed> Failed { get; set; } = new List<Failed>();

        [JsonProperty("Complete")]
        public List<Complete> Complete { get; set; } = new List<Complete>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Missions");
            sb.Append(" - Active:" + Active.Count);
            sb.Append(", Failed:" + Failed.Count);
            sb.Append(", Complete:" + Complete.Count);
            return sb.ToString();
        }
    }
}