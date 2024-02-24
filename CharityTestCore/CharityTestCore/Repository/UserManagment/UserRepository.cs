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
		public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
        public User? GetUserById(string id)
        {
            return context.Users.FirstOrDefault(x => x.Id.ToString() ==  id);
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
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
