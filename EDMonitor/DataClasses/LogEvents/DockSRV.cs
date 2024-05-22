using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class DockSRV : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dock SRV");
            return sb.ToString();
        }
    }
}