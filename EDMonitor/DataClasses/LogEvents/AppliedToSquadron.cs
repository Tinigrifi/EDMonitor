using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class AppliedToSquadron : LogEvent
    {
        [JsonProperty("SquadronName")]
        public string SquadronName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Applied To Squadron: " + SquadronName);
            return sb.ToString();
        }
    }
}