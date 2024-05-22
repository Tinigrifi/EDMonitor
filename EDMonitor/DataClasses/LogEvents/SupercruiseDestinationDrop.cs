using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class SupercruiseDestinationDrop : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Threat")]
        public int? Threat { get; set; }

        [JsonProperty("MarketID")]
        public long? MarketID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Supercruise Destination Drop");
            List<string> res = new List<string>();
            if (Type != null)
            {
                res.Add("Type: " + Type);
            }
            if (Threat != null)
            {
                res.Add("Threat: " + Threat);
            }
            if (MarketID != null)
            {
                res.Add("MarketID: " + MarketID);
            }
            string res2 = string.Join(" - ", res);
            if (res2.Length > 0)
            {
                sb.Append(" - ");
                sb.Append(res2);
            }
            return sb.ToString();
        }
    }
}