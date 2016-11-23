using System.Collections.Generic;
using System.Linq;
using DataAccess.Entity;

namespace DataAccess.Repository
{
    public class AccountRepository : BaseRepository<Account>
    {
        public List<Account> GetAll(int userId)
        {
            return Items.Where(x => x.ParentUserId == userId).ToList();
        }
    }
}