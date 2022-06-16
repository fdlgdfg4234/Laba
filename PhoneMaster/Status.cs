using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public int Idstatus { get; set; }
        public string? OrderName { get; set; }
        public string? OrderStatus { get; set; }
        
        public string? Masters { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
