using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DatalinkVoucher : LogEvent
    {
        [JsonProperty("Reward")]
        public int? Reward { get; set; }

        [JsonProperty("VictimFaction")]
        public string VictimFaction { get; set; }

        [JsonProperty("PayeeFaction")]
        public string PayeeFaction { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Datalink Voucher - ");
            sb.Append("Reward: " + Reward.ToString());
            sb.Append(" - Victim Faction: " + VictimFaction);
            sb.Append(" - Payee Faction: " + PayeeFaction);
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Victim Faction: " + VictimFaction);
                return sb.ToString();
            }
        }
    }
}