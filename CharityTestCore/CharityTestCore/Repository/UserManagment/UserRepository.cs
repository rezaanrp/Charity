using DAL.DataBase;

namespace CharityTestCore.Repository.UserManagment
{
    public class UserRepository: IUserRepository
    {
        private ParkerCharityContext context = new ParkerCharityContext();

        public IQueryable<User> usersList()
        {
            return context.Users.AsQueryable().Where(x =>x.Role == "user");
        }
        public void AddUsersList(User item)
        {
            context.Users.Add(item);
        }
        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }

        public IEnumerable<mGenGroup> mGenGroup
        {
            get { return context.mGenGroup; }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
