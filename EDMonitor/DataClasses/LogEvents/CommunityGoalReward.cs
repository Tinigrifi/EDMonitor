using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CommunityGoalReward : LogEvent
    {
        [JsonProperty("CGID")]
        public long? CGID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("System")]
        public string System { get; set; }

        [JsonProperty("Reward")]
        public long? Reward { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Community Goal");
            sb.Append(" - Reward: " + ((long)Reward).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Name: " + Name);
                return sb.ToString();
            }
        }
    }
}