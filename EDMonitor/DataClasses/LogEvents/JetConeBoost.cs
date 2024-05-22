using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class JetConeBoost: LogEvent
    {
        [JsonProperty("BoostValue")]
        public double? BoostValue { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Jet Cone Boost - ");
            sb.Append("Boost Value: ×" + (BoostValue ?? 0.0).ToString("n1", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}