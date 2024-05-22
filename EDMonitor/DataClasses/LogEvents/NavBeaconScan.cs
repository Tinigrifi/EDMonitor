using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class NavBeaconScan : LogEvent
    {
        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; set; }

        [JsonProperty("NumBodies")]
        public int NumBodies { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nav Beacon Scan: ");
            sb.Append(NumBodies + " Bodies");
            return sb.ToString();
        }
    }
}