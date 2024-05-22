using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Scanned : LogEvent
    {
        [JsonProperty("ScanType")]
        public string ScanType { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Scan Detected: ");
            sb.Append(ScanType);
            sb.Append(" Scanned");
            return sb.ToString();
        }
    }
}