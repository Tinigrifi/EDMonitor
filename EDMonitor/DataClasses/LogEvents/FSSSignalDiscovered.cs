using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FSSSignalDiscovered : LogEvent
    {
        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("SignalName")]
        public string SignalName { get; set; }

        [JsonProperty("IsStation")]
        public bool? IsStation { get; set; }

        [JsonProperty("SignalName_Localised")]
        public string SignalNameLocalised { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FSS Signal Discovered: ");
            sb.Append(string.IsNullOrEmpty(SignalNameLocalised) ? SignalName : SignalNameLocalised);
            sb.Append(IsStation == true ? " (Station)" : "");
            return sb.ToString();
        }
    }
}