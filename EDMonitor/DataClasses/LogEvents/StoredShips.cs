using EDMonitor.DataClasses.LogEvents.StoredShipsJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class StoredShips : LogEvent
    {
        [JsonProperty("StationName")]
        public string StationName { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("ShipsHere")]
        public List<ShipsHere> ShipsHere { get; set; } = new List<ShipsHere>();

        [JsonProperty("ShipsRemote")]
        public List<ShipsRemote> ShipsRemote { get; set; } = new List<ShipsRemote>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Stored Ships in");
            sb.Append(" " + StationName);
            sb.Append(" / " + StarSystem);
            sb.Append(" - " + ShipsHere.Count + " Here");
            sb.Append(", " + ShipsRemote.Count + " Remote");
            return sb.ToString();
        }
    }
}