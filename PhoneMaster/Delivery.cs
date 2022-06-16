using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Delivery
    {
        public Delivery()
        {
            Orders = new HashSet<Order>();
        }

        public int Iddelivery { get; set; }
        public int Idadress { get; set; }
        public int Idpayment { get; set; }

        public virtual Adress IdadressNavigation { get; set; } = null!;
        public virtual Payment IdpaymentNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
