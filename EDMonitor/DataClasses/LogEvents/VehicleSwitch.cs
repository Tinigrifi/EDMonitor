using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class VehicleSwitch : LogEvent
    {
        [JsonProperty("To")]
        public string To { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Vehicle Switch To " + To);
            return sb.ToString();
        }
    }
}