using DataAccess.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repository
{
    public class ContactsRepository : BaseRepository<Contact>
    {
        public List<Contact> GetAll(int currentUserId)
        {
            return Items.Where(i => i.CurrentUserId == currentUserId).ToList();
        }
    }
}