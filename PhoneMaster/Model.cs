using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Model
    {
        public Model()
        {
            Phones = new HashSet<Phone>();
        }

        public int Idmodel { get; set; }
        public string Name { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
