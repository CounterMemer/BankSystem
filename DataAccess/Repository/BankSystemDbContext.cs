using System.Data.Entity;
using DataAccess.Entity;

namespace DataAccess.Repository
{
    public sealed class BankSystemDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public BankSystemDbContext() : base("BankSystemConnectionString")
        {
            Users = Set<User>();
            Accounts = Set<Account>();
            Cards = Set<Card>();
            Transactions = Set<Transaction>();
            Branches = Set<Branch>();
        }
    }
}