namespace DataAccess.Repository
{
    public class RepositoryFactory
    {
        public static UsersRepository GetUsersRepository()
        {
            return new UsersRepository();
        }

        public static ContactsRepository GetContactsRepository()
        {
            return new ContactsRepository();
        }

        public static PhonesRepository GetPhonesRepository()
        {
            return new PhonesRepository();
        }
    }
}
