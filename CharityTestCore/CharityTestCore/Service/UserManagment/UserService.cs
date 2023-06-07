using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using DAL.DataBase;
using NewsAgency.Utilities;

namespace CharityTestCore.Service.UserManagment
{
    public class UserService : IUserService
    {


        public bool ChangePassword(string username, string oldPassword, string newPassword,IUserRepository userRepository)
        {

            var user = userRepository.Users.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return false;
            }
            if (CryptographyHelper.Encrypt(oldPassword) != user.HashPassword)
            {
                return false;
            }
            user.HashPassword = CryptographyHelper.Encrypt(newPassword);
            userRepository.SaveChanges();
            return true;
        }

        public User? Authenticate(string username, string password, IUserRepository userRepository)
        {
            string username_ = username.Trim().ToLower();
            if(!userRepository.Users.Any())
            {
               new  DAL.DataBase.Seed().SeedData( );
            }
            var u = userRepository.Users.FirstOrDefault(x => x.UserName == username_ && x.HashPassword == CryptographyHelper.Encrypt(password));
            return u;

        }
        public Guid? AddUser(string username, string password, string name, string family, string role, string nationalcode, IUserRepository userRepository)
        {
            try
            {
                var user = new User
                {
                    Family = family,
                    Name = name,
                    UserName = username,
                    Role = role,
                    HashPassword = password,
                    NationalNumber = nationalcode
                };
                userRepository.AddUsersList(user);
                userRepository.SaveChanges();
                return user.Id;
            }
            catch (Exception)
            {
                return null;
            }

        }


    }
}
