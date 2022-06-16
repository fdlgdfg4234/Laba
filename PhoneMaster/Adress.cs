using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Adress
    {
        public Adress()
        {
            Deliveries = new HashSet<Delivery>();
        }

        public int Idadress { get; set; }
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string House { get; set; } = null!;
        public string Flat { get; set; } = null!;

        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
