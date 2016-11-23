using System.Collections.Generic;
using System.Linq;
using DataAccess.Entity;

namespace DataAccess.Repository
{
    public class BranchRepository : BaseRepository<Branch>
    {
        public List<Branch> GetAll()
        {
            return Items.ToList();
        }
    }
}