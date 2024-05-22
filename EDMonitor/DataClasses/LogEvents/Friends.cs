using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Friends : LogEvent
    {
        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Your Friend " + Name + " is " + Status);
            return sb.ToString();
        }
    }
}