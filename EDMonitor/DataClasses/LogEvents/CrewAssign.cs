using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CrewAssign : LogEvent
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CrewID")]
        public long? CrewID { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Crew: " + Name + " assigned to " + Role);
            return sb.ToString();
        }
    }
}