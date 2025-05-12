using DAL.DataBase;
using DAL.Dtos;
using Microsoft.EntityFrameworkCore;

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
		public bool EditUsersList(Models.UserListModel item,string newpassword)
		{
            try
            {
				var mm = context.Users.FirstOrDefault(x => x.Id == item.Id);
                if (mm != null)
                {
					mm.MobileNumber = item.MobileNumber;
					mm.NationalNumber = item.NationalNumber;
					mm.Name = item.Name;
					mm.Family = item.Family;
					mm.HashPassword = newpassword;
					context.SaveChanges();
					return true;

				}
				return false;

			}
			catch (Exception)
            {

                return false;
            }



		}

        public List<UserExamStatusDtos> GetUsersWithExamStatus()
        {
            var users = context.Users.Where(u => !u.IsDelete).ToList();

            var mbtiDict = context.MBTIAnswerList
                            .GroupBy(x => x.UserId)
                            .ToDictionary(g => g.Key, g => g.FirstOrDefault()?.Result);

            var eptUserIds = context.EptQuestion
                                .Select(x => x.UserId_)
                                .Distinct()
                                .ToHashSet();

            var result = users.Select(u => new UserExamStatusDtos
            {
                Id = u.Id,
                Name = u.Name,
                Family = u.Family,
                UserName = u.UserName,
                NationalNumber = u.NationalNumber,
                MobileNumber = u.MobileNumber,
                MbtiResult = mbtiDict.ContainsKey(u.Id) ? mbtiDict[u.Id] : null,
                HasMBTI = mbtiDict.ContainsKey(u.Id) ,
                HasEPT = eptUserIds.Contains(u.Id.ToString())
            }).ToList();

            return result;
        }


        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
        public User? GetUserById(string id)
        {
            return context.Users.FirstOrDefault(x => x.Id.ToString() ==  id);
        }
        public async Task<User> GetByIdAsync(Guid id)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task UpdateAsync(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
        public IEnumerable<mGenGroup> mGenGroup
        {
            get { return context.mGenGroup; }
        }
        public bool Delete(User item)
        {
            try {
                context.Users.Remove(item);
                context.SaveChanges();
                return true;
            
            }

            catch
            {
                return false;
            }
        }
        public void Update(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
