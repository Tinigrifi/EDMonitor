using EDMonitor.Business;
using EDMonitor.DataClasses.LogEvents.DockedJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class RefuelPartial : LogEvent
    {
        [JsonProperty("Cost")]
        public long? Cost { get; set; }

        [JsonProperty("Amount")]
        public int? Amount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Refuel Partial");
            sb.Append(" - Amount: " + ((double)Amount).ToString("n3", CultureInfo.InvariantCulture) + " T");
            sb.Append(" - Cost: " + ((int)Cost).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append((Amount ??  0).ToString() + "T");
                return sb.ToString();
            }
        }
    }
}
