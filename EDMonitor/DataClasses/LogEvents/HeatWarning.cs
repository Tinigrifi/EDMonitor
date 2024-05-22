using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class HeatWarning : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Heat Warning!");
            return sb.ToString();
        }
    }
}