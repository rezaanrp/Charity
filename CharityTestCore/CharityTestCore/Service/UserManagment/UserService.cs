using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Repository.UserManagment;
using CharityTestCore.Tools;
using DAL.DataBase;
using DAL.Dtos;
using NewsAgency.Utilities;

namespace CharityTestCore.Service.UserManagment
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IEPTRepository _EPTRepository;
        private readonly IMBTIRepository _mBTIRepository;
        
        public UserService(
            IUserRepository _userRepository,
            IEPTRepository EPTRepository,
            IMBTIRepository mBTIRepository
            
            )
        {

            userRepository = _userRepository;
            _EPTRepository = EPTRepository;
            _mBTIRepository = mBTIRepository;

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

            var u = userRepository.Users.FirstOrDefault(x => x.UserName == username_ && x.HashPassword == CryptographyHelper.Encrypt(password));

            if (u != null)
            {
                u.LastLoginDate = DateTime.Now;
                userRepository.Update(u); // مطمئن شو این متد تغییرات رو ذخیره می‌کنه
            }

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
		public bool EditUser(Models.UserListModel userListModel)
		{
			try
			{
					
			 return	userRepository.EditUsersList(userListModel, CryptographyHelper.Encrypt(userListModel.Password));
			}
			catch (Exception)
			{
				return false;
			}

		}
        public List<UserProfileModel> GetAllUser()
        {
            return userRepository.usersList()
                .Select(u => new UserProfileModel
                {
                    Id = u.Id,
                    Name = u.Name,
                    Family = u.Family,
                    Role = u.Role,
                    MobileNumber = u.MobileNumber,
                    NationalNumber = u.NationalNumber,
                    UserName = u.UserName
                })
                .ToList();
        }

        public List<UserExamStatusViewModel> GetAllByQuizUser()
        {
            var model = userRepository.GetUsersWithExamStatus().Select(u => new UserExamStatusViewModel
            { 
                Family = u.Family,
                Role = u.Role,  
                MobileNumber = u.MobileNumber,
                NationalNumber = u.NationalNumber,
                UserName = u.UserName,
                Name = u.Name,
                HasEPT = u.HasEPT,
                HasMBTI = u.HasMBTI,
                Id = u.Id,

                
            });

            return model.ToList();


        }
        public UserProfileModel? GetProfile(string userid)
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
                    CreatedDate = u.CreatedDate,
                    LastLoginDate = u.LastLoginDate,

                };
                return model;

            }
            else return null;

        }
        public int CountNationalNumber(string code)
        {

            var u = userRepository.Users.Where(x => x.NationalNumber.ToString() == code).Count();
            return u;

        }
        public int CountMobile(string code)
        {

            var u = userRepository.Users.Where(x => x.MobileNumber.ToString() == code).Count();
			return u;


		}
		public int CountUserName(string code)
        {

            var u = userRepository.Users.Where(x => x.UserName.ToString() == code).Count();
			return u;


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
		public UserListModel? GetByIdUserListModel(string Id)
		{
			UserListModel model = new UserListModel();

			var us = userRepository.GetUserById(Id);
			if (us != null)
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
			else { return new UserListModel(); }

		}

        public bool DeleteUser(string Id)
        {
            var us = userRepository.GetUserById(Id);
            if(us != null )
            {
                
                return userRepository.Delete(us);
            }
            else
            {
                return false;
            }

        }

    }
}
