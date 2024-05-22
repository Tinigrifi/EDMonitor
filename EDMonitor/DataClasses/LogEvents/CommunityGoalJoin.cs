using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CommunityGoalJoin : LogEvent
    {
        [JsonProperty("CGID")]
        public long? CGID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Community Goal - Join: ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}