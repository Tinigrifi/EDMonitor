using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShieldState : LogEvent
    {
        [JsonProperty("ShieldsUp")]
        public bool? ShieldsUp { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (ShieldsUp != null && ShieldsUp == true)
            {
                sb.Append("Shields Up");
            }
            if (ShieldsUp != null && ShieldsUp == false)
            {
                sb.Append("Silent Mode");
            }
            return sb.ToString();
        }
    }
}