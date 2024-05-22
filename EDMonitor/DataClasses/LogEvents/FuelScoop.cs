using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FuelScoop : LogEvent
    {
        [JsonProperty("Scooped")]
        public double? Scooped { get; set; }

        [JsonProperty("Total")]
        public double? Total { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Fuel Scoop: ");
            sb.Append(((double)Scooped).ToString("n3", CultureInfo.InvariantCulture) + " T");
            sb.Append(" - Total: ");
            sb.Append(((double)Total).ToString("n3", CultureInfo.InvariantCulture) + " T");
            return sb.ToString();
        }
    }
}