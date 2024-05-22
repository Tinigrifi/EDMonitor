using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class StartJump : LogEvent
    {
        [JsonProperty("JumpType")]
        public string JumpType { get; set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; set; }

        [JsonProperty("SystemAddress")]
        public long? SystemAddress { get; set; }

        [JsonProperty("StarClass")]
        public string StarClass { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(">> Start Jump");
            sb.Append(" " + JumpType);
            sb.Append((string.IsNullOrEmpty(StarSystem)) ? "" : " to " + StarSystem + " [" + StarClass.ToUpper() + "]" + IsScoopable(StarClass));
            return sb.ToString();
        }

        private string IsScoopable (string starClass)
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