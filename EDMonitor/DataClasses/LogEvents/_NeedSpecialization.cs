using System.Text;

namespace EDMonitor.DataClasses.LogEvents
{
    public class NeedSpecialization : LogEvent
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(EventType);
            sb.Append(" >>>>>>>> NEED SPECIALIZATION <<<<<<<<");
            return sb.ToString();
        }
    }
}