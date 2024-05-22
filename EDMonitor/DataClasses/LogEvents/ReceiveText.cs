using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ReceiveText : LogEvent
    {
        [JsonProperty("From")]
        public string From { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Message_Localised")]
        public string MessageLocalised { get; set; }

        [JsonProperty("Channel")]
        public string Channel { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Receive Text");
            sb.Append(" from ");
            sb.Append(ProcessFrom(From));
            sb.Append(": ");
            sb.Append(string.IsNullOrEmpty(MessageLocalised) ? Message : MessageLocalised);
            return sb.ToString();
        }

        public string FromProcessed
        {
            get
            {
                return ProcessFrom(From);
            }
        }

        private string ProcessFrom(string from)
        {
            if (from.StartsWith("$"))
            {
                from = from.Substring(1);
            }
            if (from.EndsWith(";"))
            {
                from = from.Substring(0, from.Length - 1);
            }
            string pattern = "^([^:]*):#name=(.*)$";
            Match match = Regex.Match(from, pattern);
            if (match.Success)
            {
                from = match.Groups[2].Value;
            }
            if (string.IsNullOrEmpty(from))
            {
                from = "System";
            }
            from = from.Replace('_', ' ');
            from = from.Replace("ShipName ", "");
            return from;
        }
    }
}