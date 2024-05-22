using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class UnderAttack : LogEvent
    {
        [JsonProperty("Target")]
        public string Target { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UnderAttack!");
            sb.Append(" Target:");
            sb.Append(" " + Target);
            return sb.ToString();
        }
    }
}