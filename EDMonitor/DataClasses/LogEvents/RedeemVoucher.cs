using EDMonitor.DataClasses.LogEvents.RedeemVoucherJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class RedeemVoucher : LogEvent
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Amount")]
        public int? Amount { get; set; }

        [JsonProperty("Factions")]
        public List<Faction> Factions { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Redeem Voucher");
            if (Amount != null)
            {
                sb.Append(" - Amount: " + ((int)Amount).ToString("n0", CultureInfo.InvariantCulture) + " CR");
            }
            return sb.ToString();
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Factions.Count.ToString() + " Factions");
                return sb.ToString();
            }
        }
    }
}