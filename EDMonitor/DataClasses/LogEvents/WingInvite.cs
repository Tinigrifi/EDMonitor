using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class WingInvite : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " Invited You to a Wing");
            return sb.ToString();
        }
    }
}