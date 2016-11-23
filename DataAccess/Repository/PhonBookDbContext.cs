using DataAccess.Entity;
using System.Data.Entity;

namespace DataAccess.Repository
{
    public sealed class PhonBookDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public PhonBookDbContext() : base("BankSystemConnectionString")
        {
            Users = Set<User>();
            Contacts = Set<Contact>();
            Phones = Set<Phone>();
        }
    }
}
