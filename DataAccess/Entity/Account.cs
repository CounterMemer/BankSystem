namespace DataAccess.Entity
{
    public class Account : BaseEntity
    {
        public int ParentUserId { get; set; }

        public string Iban { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }
}