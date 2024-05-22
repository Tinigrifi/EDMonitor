using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class AsteroidCracked : LogEvent
    {
        [JsonProperty("Body")]
        public string Body { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Asteroid Cracked near " + Body);
            return sb.ToString();
        }
    }
}