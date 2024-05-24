using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class PayBounties : LogEvent
    {
        [JsonProperty("Amount")]
        public int? Amount { get; set; }

        [JsonProperty("Faction")]
        public string Faction { get; set; }

        [JsonProperty("Faction_Localised")]
        public string FactionLocalised { get; set; }

        [JsonProperty("ShipID")]
        public int? ShipID { get; set; }

        [JsonProperty("BrokerPercentage")]
        public int? BrokerPercentage { get; set; }

        [JsonProperty("AllFines")]
        public bool? AllFines { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bounties paid: " + Amount.ToString() + " CR");
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Bounties");
                return sb.ToString();
            }
        }
    }
}