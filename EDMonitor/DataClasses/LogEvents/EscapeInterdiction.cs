using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class EscapeInterdiction : LogEvent
    {
        [JsonProperty("Interdictor")]
        public string Interdictor { get; set; }

        [JsonProperty("IsPlayer")]
        public bool? IsPlayer { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Escape Interdiction - ");
            sb.Append("Interdictor: " + Interdictor);
            sb.Append((IsPlayer != null && IsPlayer == true) ? " (Player)" : "");
            return sb.ToString();
        }
    }
}