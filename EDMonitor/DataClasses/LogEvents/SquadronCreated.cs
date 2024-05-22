using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SquadronCreated : LogEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Squadron Created: ");
            sb.Append(SquadronName);
            return sb.ToString();
        }
    }
}