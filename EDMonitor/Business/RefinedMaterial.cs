using System;

namespace EDMonitor.Business
{
    public class RefinedMaterial
    {
        public string Name { get; set; }

        public DateTime Timestamp { get; set; }

        public override string ToString() => TimeZone.CurrentTimeZone.ToLocalTime(Timestamp).ToString("HH:mm:ss") + " " + Name;
    }
}