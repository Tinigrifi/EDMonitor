using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class BuyAmmo : LogEvent
    {
        [JsonProperty("Cost")]
        public long? Cost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Buy Ammo");
            if (Cost != null)
            {
                sb.Append(" - Cost: " + ((long)Cost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }
    }
}