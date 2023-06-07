using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using DAL.DataBase;

namespace CharityTestCore.Service.UserManagment
{
    public interface IUserService
    {
        bool ChangePassword(string username, string oldPassword, string newPassword,IUserRepository userRepository );
        User? Authenticate(string username, string password , IUserRepository userRepository);
        Guid? AddUser(string username, string password, string name, string family, string role, string nationalcode, IUserRepository userRepository);
    }
}
