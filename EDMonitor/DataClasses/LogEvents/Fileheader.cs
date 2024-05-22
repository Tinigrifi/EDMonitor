using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Fileheader : LogEvent
    {
        [JsonProperty("part")]
        public long? Part { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("gameversion")]
        public string Gameversion { get; set; }

        [JsonProperty("build")]
        public string Build { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Elite Dangerous");
            sb.Append(" - version:" + Gameversion);
            sb.Append(" - " + Build);
            sb.Append(" - lang: " + Language);
            return sb.ToString();
        }
    }
}