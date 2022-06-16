using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class User
    {
        public User()
        {
            UserLists = new HashSet<UserList>();
        }

        public int Iduser { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Login { get; set; }
        public string? TelephoneNumber { get; set; }

        //public virtual Role IduserNavigation { get; set; } = null!;
        public virtual ICollection<UserList> UserLists { get; set; }
    }
}
