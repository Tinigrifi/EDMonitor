using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class HeatDamage : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Heat Damage!");
            return sb.ToString();
        }
    }
}