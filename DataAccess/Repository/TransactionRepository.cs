using System.Collections.Generic;
using System.Linq;
using DataAccess.Entity;

namespace DataAccess.Repository
{
    public class TransactionRepository : BaseRepository<Transaction>
    {
        public List<Transaction> GetAll(int parentUserId)
        {
            return Items.Where(x => x.ParentUserId == parentUserId).ToList();
        }
    }
}