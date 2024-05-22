using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class MissionRedirected : LogEvent
    {
        [JsonProperty("MissionID")]
        public int MissionID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NewDestinationStation")]
        public string NewDestinationStation { get; set; }

        [JsonProperty("NewDestinationSystem")]
        public string NewDestinationSystem { get; set; }

        [JsonProperty("OldDestinationStation")]
        public string OldDestinationStation { get; set; }

        [JsonProperty("OldDestinationSystem")]
        public string OldDestinationSystem { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mission Redirected: ");
            sb.Append(Name.Replace('_', ' ').Replace(" name", ""));
            sb.Append(" - From " + (string.IsNullOrEmpty(OldDestinationStation) ? "" : OldDestinationStation + " / ") + OldDestinationSystem);
            sb.Append(" To " + (string.IsNullOrEmpty(NewDestinationStation) ? "" : NewDestinationStation + " / ") + NewDestinationSystem);
            return sb.ToString();
        }
    }
}