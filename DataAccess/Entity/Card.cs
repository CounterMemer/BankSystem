using System;

namespace DataAccess.Entity
{
    public class Card : BaseEntity

    {
        public int ParentAccountId { get; set; }

        public string CardNumber { get; set; }
        public int CardType { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public DateTime ValidThru { get; set; }
    }
}