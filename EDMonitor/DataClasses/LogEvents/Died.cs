using EDMonitor.DataClasses.LogEvents.DiedJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Died : LogEvent
    {
        [JsonProperty("KillerName")]
        public string KillerName { get; set; }

        [JsonProperty("KillerShip")]
        public string KillerShip { get; set; }

        [JsonProperty("KillerRank")]
        public string KillerRank { get; set; }

        [JsonProperty("Killers")]
        public List<Killer> Killers { get; set; } = new List<Killer>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("You Died!");
            return sb.ToString();
        }
    }
}