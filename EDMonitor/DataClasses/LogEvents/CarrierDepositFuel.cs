using Newtonsoft.Json;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    internal class CarrierDepositFuel : LogEvent
    {
        [JsonProperty("CarrierID")]
        public long CarrierID { get; set; }

        [JsonProperty("Amount")]
        public int Amount { get; set; }

        [JsonProperty("Total")]
        public int Total { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Carrier Deposit Fuel");
            sb.Append(" - Amount: ");
            sb.Append(Amount.ToString());
            sb.Append(" - Total: ");
            sb.Append(Total.ToString());
            return sb.ToString();
        }
    }
}