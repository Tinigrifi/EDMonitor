using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class HullDamage : LogEvent
    {
        [JsonProperty("Health")]
        public double? Health { get; set; }

        [JsonProperty("PlayerPilot")]
        public bool? PlayerPilot { get; set; }

        [JsonProperty("Fighter")]
        public bool? Fighter { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hull Damage");
            sb.Append(" - Health: " + ((double)Health).ToString("P", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}