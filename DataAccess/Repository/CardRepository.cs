using System.Collections.Generic;
using System.Linq;
using DataAccess.Entity;

namespace DataAccess.Repository
{
    public class CardRepository : BaseRepository<Card>
    {
        public List<Card> GetAll(int accountId)
        {
            return Items.Where(x => x.ParentAccountId == accountId).ToList();
        }
    }
}