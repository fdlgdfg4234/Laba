using System;
using System.Collections.Generic;

namespace PhoneMaster
{
    public partial class Card
    {
        public Card()
        {
            Payments = new HashSet<Payment>();
        }

        public int Idcard { get; set; }
        public string NumberOfCard { get; set; } = null!;
        public DateTime ValidityPeriod { get; set; }
        public string Cvv { get; set; } = null!;
        public string? NameOfOwner { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
