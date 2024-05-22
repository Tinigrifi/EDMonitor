using EDMonitor.DataClasses.LogEvents.FSDJumpJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class FSDJump : LogEvent
    {
        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("StarPos")]
        public List<double> StarPos { get; set; } = new List<double>();

        [JsonProperty("SystemAllegiance")]
        public string SystemAllegiance { get; set; }

        [JsonProperty("SystemEconomy")]
        public string SystemEconomy { get; set; }

        [JsonProperty("SystemEconomy_Localised")]
        public string SystemEconomyLocalised { get; set; }

        [JsonProperty("SystemSecondEconomy")]
        public string SystemSecondEconomy { get; set; }

        [JsonProperty("SystemSecondEconomy_Localised")]
        public string SystemSecondEconomyLocalised { get; set; }

        [JsonProperty("SystemGovernment")]
        public string SystemGovernment { get; set; }

        [JsonProperty("SystemGovernment_Localised")]
        public string SystemGovernmentLocalised { get; set; }

        [JsonProperty("SystemSecurity")]
        public string SystemSecurity { get; set; }

        [JsonProperty("SystemSecurity_Localised")]
        public string SystemSecurityLocalised { get; set; }

        [JsonProperty("Population")]
        public long? Population { get; set; }

        [JsonProperty("JumpDist")]
        public double? JumpDist { get; set; }

        [JsonProperty("FuelUsed")]
        public double? FuelUsed { get; set; }

        [JsonProperty("FuelLevel")]
        public double? FuelLevel { get; set; }

        [JsonProperty("Factions")]
        public List<Faction> Factions { get; set; } = new List<Faction>();

        [JsonProperty("SystemFaction")]
        public SystemFaction SystemFaction { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<< FSD Jump");
            sb.Append((string.IsNullOrEmpty(StarSystem)) ? "" : " to " + StarSystem);
            sb.Append(" - " + ((double)JumpDist).ToString("n2", CultureInfo.InvariantCulture) + " Ly");
            return sb.ToString();
        }

        private string IsScoopable(string starClass)
        {
            if (
                   starClass.ToUpper() == "K"
                || starClass.ToUpper() == "G"
                || starClass.ToUpper() == "B"
                || starClass.ToUpper() == "F"
                || starClass.ToUpper() == "O"
                || starClass.ToUpper() == "A"
                || starClass.ToUpper() == "M"
                )
            {
                return " (Scoopable)";
            }
            return "";
        }
    }
}