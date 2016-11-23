using DataAccess.Entity;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Repository
{
    public class PhonesRepository : BaseRepository<Phone>
    {
        public List<Phone> GetAll(int currentContactId)
        {
            return Items.Where(i => i.CurrentContactId == currentContactId).ToList();
        }
    }
}