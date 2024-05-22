using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class LoadGame : LogEvent
    {
        [JsonProperty("Commander")]
        public string Commander { get; set; }

        [JsonProperty("FID")]
        public string FID { get; set; }

        [JsonProperty("Horizons")]
        public bool? Horizons { get; set; }

        [JsonProperty("Odyssey")]
        public bool? Odyssey { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public long? ShipID { get; set; }

        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; set; }

        [JsonProperty("StartLanded")]
        public bool? StartLanded { get; set; }

        [JsonProperty("StartDead")]
        public bool? StartDead { get; set; }

        [JsonProperty("GameMode")]
        public string GameMode { get; set; }

        [JsonProperty("Group")]
        public string Group { get; set; }

        [JsonProperty("Credits")]
        public long? Credits { get; set; }

        [JsonProperty("Loan")]
        public long? Loan { get; set; }

        [JsonProperty("ShipName")]
        public string ShipName { get; set; }

        [JsonProperty("ShipIdent")]
        public string ShipIdent { get; set; }

        [JsonProperty("FuelLevel")]
        public double? FuelLevel { get; set; }

        [JsonProperty("FuelCapacity")]
        public double? FuelCapacity { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("gameversion")]
        public string Gameversion { get; set; }

        [JsonProperty("build")]
        public string Build { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Load Game");
            sb.Append(" (" + GameMode + ")");
            sb.Append(" - " + Commander);
            sb.Append(" in " + (string.IsNullOrEmpty(ShipName) ? "" : ShipName + " ("));
            sb.Append(string.IsNullOrEmpty(ShipLocalised) ? Ship : ShipLocalised);
            sb.Append(string.IsNullOrEmpty(ShipName) ? "" : ")");
            return sb.ToString();
        }
    }
}