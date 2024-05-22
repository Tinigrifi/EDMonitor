using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Progress : LogEvent
    {
        [JsonProperty("Combat")]
        public int? Combat { get; set; }

        [JsonProperty("Trade")]
        public int? Trade { get; set; }

        [JsonProperty("Explore")]
        public int? Explore { get; set; }

        [JsonProperty("Empire")]
        public int? Empire { get; set; }

        [JsonProperty("Federation")]
        public int? Federation { get; set; }

        [JsonProperty("CQC")]
        public int? CQC { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Progress");
            sb.Append(" - Combat:" + (((double)Combat / 100)).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", Trade:" + (((double)Trade / 100)).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", Explore:" + (((double)Explore / 100)).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", CQC:" + (((double)CQC / 100)).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(" / Empire:" + (((double)Empire / 100)).ToString("P", CultureInfo.InvariantCulture));
            sb.Append(", Federation:" + (((double)Federation / 100)).ToString("P", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}