using CharityTestCore.Models;
using DAL.DataBase;

namespace CharityTestCore.Repository.UserManagment
{
    public interface IUserRepository
    {
        public IQueryable<User> usersList();
        public void AddUsersList(User item);
       
        public IEnumerable<User> Users { get; }

        public IEnumerable<mGenGroup> mGenGroup { get; }
        public void SaveChanges();

        public User? GetUserById(string id);


    }
}
