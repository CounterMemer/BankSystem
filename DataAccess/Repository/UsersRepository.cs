using DataAccess.Entity;
using System.Linq;

namespace DataAccess.Repository
{
    public class UsersRepository : BaseRepository<User>
    {
        public User GetByUsernameAndPassword(string username, string password)
        {
            return Items.FirstOrDefault(
                i => i.Username == username && i.Password == password);
        }
    }
}
