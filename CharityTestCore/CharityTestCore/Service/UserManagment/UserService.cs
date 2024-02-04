using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using DAL.DataBase;
using NewsAgency.Utilities;

namespace CharityTestCore.Service.UserManagment
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {

            userRepository = _userRepository;

        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
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

        public User? Authenticate(string username, string password)
        {
            string username_ = username.Trim().ToLower();
            //if(!userRepository.Users.Any())
            //{
            //   new  DAL.DataBase.Seed().SeedData( );
            //}
            var u = userRepository.Users.FirstOrDefault(x => x.UserName == username_ && x.HashPassword == CryptographyHelper.Encrypt(password));
            return u;

        }
        public Guid? AddUser(string username, string password, string name, string family, string role, string nationalcode,string mobile)
        {
            try
            {
                var user = new User
                {
                    Family = family,
                    Name = name,
                    UserName = username,
                    Role = role,
                    HashPassword = CryptographyHelper.Encrypt(password),
                    NationalNumber = nationalcode,
                    MobileNumber = mobile
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
        public List<UserProfileModel>  GetAllUser()
        {
             var m = userRepository.usersList().ToList();
            List<UserProfileModel> mm = new List<UserProfileModel>();
            for (int i = 0; i < m.Count; i++)
            {
                UserProfileModel um = new UserProfileModel();
                um.Id = m[i].Id;
                um.Name = m[i].Name;
                um.Family = m[i].Family;
                um.Role = m[i].Role;
                um.MobileNumber = m[i].MobileNumber;
                um.NationalNumber = m[i].NationalNumber;    
                um.UserName = m[i].UserName;
                mm.Add(um);
			}
            return mm;
		}

       public  UserProfileModel? GetProfile(string userid)
        {

            var u = userRepository.Users.FirstOrDefault(x => x.Id.ToString() == userid);
            if (u != null)
            {
                UserProfileModel model = new UserProfileModel()
                {
                    MobileNumber = u.MobileNumber,
                    Family = u.Family,
                    Name = u.Name,
                    NationalNumber = u.NationalNumber,
                    Id = u.Id,
                    Role = u.Role,
                   
                    

                };
                return model;

            }
            else return null;

        }
        public bool IsExistNationalNumber(string code)
        {

            var u = userRepository.Users.FirstOrDefault(x => x.NationalNumber.ToString() == code);
           if(u == null)
            {
                return false;
            }
           else
                return true;

        }
        public bool IsExistMobile(string code)
        {

            var u = userRepository.Users.FirstOrDefault(x => x.MobileNumber.ToString() == code);
            if (u == null)
            {
                return false;
            }
            else
                return true;

        }
        public bool IsExistUserName(string code)
        {

            var u = userRepository.Users.FirstOrDefault(x => x.UserName.ToString() == code);
            if (u == null)
            {
                return false;
            }
            else
                return true;

        }
        public UserProfileModel? GetById(string Id)
        {
            UserProfileModel model = new UserProfileModel();

            var us = userRepository.GetUserById(Id);
            if(us != null)
            {
                model.MobileNumber = us.MobileNumber;
                model.Family = us.Family;
                model.Name = us.Name;
                model.NationalNumber = us.NationalNumber;   
                model.UserName = us.UserName;
                model.Id = us.Id;
                model.Role = us.Role;
                return model;
            }
            else { return new UserProfileModel(); }

        }

    }
}
