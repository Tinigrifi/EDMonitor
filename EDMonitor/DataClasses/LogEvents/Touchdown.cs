using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Touchdown : LogEvent
    {
        [JsonProperty("PlayerControlled")]
        public bool? PlayerControlled { get; set; }

        [JsonProperty("Latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double? Longitude { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Touchdown");
            if (Latitude != null && Longitude != null)
            {
                sb.Append(" - Latitude: " + ((double)(Latitude ?? 0.0)).ToString("n3", CultureInfo.InvariantCulture));
                sb.Append(", Longitude: " + ((double)(Longitude ?? 0.0)).ToString("n3", CultureInfo.InvariantCulture));
            }
            if (PlayerControlled != null && PlayerControlled == true)
            {
                sb.Append(" - Player Controlled");
            }
            return sb.ToString();
        }
    }
}