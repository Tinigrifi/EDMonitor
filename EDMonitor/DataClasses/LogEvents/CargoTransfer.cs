using EDMonitor.DataClasses.LogEvents.CargoTransferJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class CargoTransfer : LogEvent
    {
        [JsonProperty("Transfers")]
        public List<Transfer> Transfers { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cargo - Transfer: ");
            sb.Append(Transfers.Count + " Transfers");
            return sb.ToString();
        }
    }
}