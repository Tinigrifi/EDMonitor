using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class WingLeave : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("You Leaved the Wing");
            return sb.ToString();
        }
    }
}