using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Order
    {
        public Order()
        {
            UserLists = new HashSet<UserList>();
        }

        public int Idorder { get; set; }
        public int Idphone { get; set; }
        public int Idstatus { get; set; }
        public int Idmaster { get; set; }
        public int Iddelivery { get; set; }

        public virtual Delivery IddeliveryNavigation { get; set; } = null!;
        public virtual Phone IdphoneNavigation { get; set; } = null!;
        public virtual Status IdstatusNavigation { get; set; } = null!;
        public virtual ICollection<UserList> UserLists { get; set; }
    }
}
