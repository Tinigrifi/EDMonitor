using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ShipTargeted : LogEvent
    {
        [JsonProperty("TargetLocked")]
        public bool? TargetLocked { get; set; }

        [JsonProperty("Ship")]
        public string Ship { get; set; }

        [JsonProperty("Ship_Localised")]
        public string ShipLocalised { get; set; }

        [JsonProperty("ScanStage")]
        public int? ScanStage { get; set; }

        [JsonProperty("PilotName")]
        public string PilotName { get; set; }

        [JsonProperty("PilotName_Localised")]
        public string PilotNameLocalised { get; set; }

        [JsonProperty("PilotRank")]
        public string PilotRank { get; set; }

        [JsonProperty("ShieldHealth")]
        public double? ShieldHealth { get; set; }

        [JsonProperty("HullHealth")]
        public double? HullHealth { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("LegalStatus")]
        public string LegalStatus { get; set; }

        [JsonProperty("Bounty")]
        public int? Bounty { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (ScanStage)
            {
                case null:
                    sb.Append("No target locked.");
                    break;
                case 0:
                    sb.Append("Ship Targeted [" + ScanStage.ToString() + "]:");
                    sb.Append(" Ship: " + Ship);
                    break;
                case 1:
                    sb.Append("[1] Pilot: " + (string.IsNullOrEmpty(PilotNameLocalised) ? "Unknown Pilot" : PilotNameLocalised));
                    sb.Append(" (" + (string.IsNullOrEmpty(PilotRank) ? "Unknown Rank" : PilotRank) + ")");
                    break;
                case 2:
                    sb.Append("[2] Shield: " + ShieldHealth.ToString());
                    sb.Append(" - Hull: " + HullHealth.ToString());
                    break;
                case 3:
                    sb.Append("[3] Faction: " + Faction);
                    sb.Append(" - Legal Status: " + LegalStatus);
                    sb.Append(Bounty == null ? "" : " - Bounty: " + Bounty.ToString());
                    break;
            }
            return sb.ToString();
        }
    }
}