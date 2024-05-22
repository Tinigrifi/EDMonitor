using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class InvitedToSquadron : LogEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Invited To Squadron: ");
            sb.Append(SquadronName);
            return sb.ToString();
        }
    }
}