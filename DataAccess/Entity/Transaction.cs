using System;

namespace DataAccess.Entity
{
    public class Transaction : BaseEntity
    {
        public int ParentUserId { get; set; }

        public int Type { get; set; }
        public DateTime Date { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }
}