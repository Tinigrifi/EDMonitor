using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class PayLegacyFines : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Pay Legacy Fines");
            return sb.ToString();
        }
    }
}