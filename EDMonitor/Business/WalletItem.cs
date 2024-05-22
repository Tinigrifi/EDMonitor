using System;

namespace EDMonitor.Business
{
    public class WalletItem
    {
        public DateTime Timestamp { get; set; }

        public string Description { get; set; }

        public long Price { get; set; }
    }
}