using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class ReservoirReplenished : LogEvent
    {
        [JsonProperty("FuelMain")]
        public double? FuelMain { get; set; }

        [JsonProperty("FuelReservoir")]
        public double? FuelReservoir { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reservoir Replenished");
            sb.Append(" - Fuel Main: ");
            sb.Append(((double)FuelMain).ToString("n3", CultureInfo.InvariantCulture) + " T");
            sb.Append(" - Fuel Reservoir: ");
            sb.Append(((double)FuelReservoir).ToString("n3", CultureInfo.InvariantCulture) + " T");
            return sb.ToString();
        }
    }
}