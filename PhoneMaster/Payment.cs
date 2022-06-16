using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Payment
    {
        public Payment()
        {
            Deliveries = new HashSet<Delivery>();
        }

        public int Idpayment { get; set; }
        public double Count { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime Date { get; set; }
        public int Idcard { get; set; }

        public virtual Card IdcardNavigation { get; set; } = null!;
        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
