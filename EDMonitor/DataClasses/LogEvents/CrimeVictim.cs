using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CrimeVictim : LogEvent
    {
        [JsonProperty("Offender")]
        public string Offender { get; set; }

        [JsonProperty("CrimeType")]
        public string CrimeType { get; set; }

        [JsonProperty("Bounty")]
        public int? Bounty { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crime Victim - ");
            sb.Append("Crime Type: " + CrimeType);
            sb.Append(", Offender: " + Offender);
            sb.Append(", Bounty: " + ((int)Bounty).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }
    }
}