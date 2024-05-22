using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class WingAdd : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " Joined your Wing");
            return sb.ToString();
        }
    }
}