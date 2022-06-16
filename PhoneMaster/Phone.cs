using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Phone
    {
        public Phone()
        {
            Orders = new HashSet<Order>();
        }

        public int Idphone { get; set; }
        public string Imei { get; set; } = null!;
        public int Idmodel { get; set; }

        public virtual Model IdmodelNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
