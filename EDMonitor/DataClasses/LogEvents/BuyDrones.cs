using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class BuyDrones : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Count")]
        public long? Count { get; set; }

        [JsonProperty("BuyPrice")]
        public long? BuyPrice { get; set; }

        [JsonProperty("TotalCost")]
        public long? TotalCost { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Buy Drones");
            if (Count != null)
            {
                sb.Append(": " + Count.ToString());
            }
            if (TotalCost != null)
            {
                sb.Append(" - Total Cost: " + ((double)TotalCost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (Count != null)
                {
                    sb.Append(Count.ToString() + " ");
                }
                sb.Append(Type);
                return sb.ToString();
            }
        }
    }
}