using EDMonitor.DataClasses.LogEvents.PassengersJsonTypes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class Passengers : LogEvent
    {
        [JsonProperty("Manifest")]
        public List<Passenger> Manifest { get; set; } = new List<Passenger>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            long sum = 0;
            foreach (Passenger i in Manifest)
            {
                sum += (long)i.Count;
            }
            sb.Append("Passengers: ");
            sb.Append(sum);
            return sb.ToString();
        }
    }
}