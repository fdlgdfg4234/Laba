using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class UserList
    {
        public int IduserList { get; set; }
        public int Idorder { get; set; }
        public int Iduser { get; set; }

        public virtual Order IdorderNavigation { get; set; } = null!;
        public virtual User IduserNavigation { get; set; } = null!;
    }
}
