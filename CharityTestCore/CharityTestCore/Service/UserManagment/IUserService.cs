using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using DAL.DataBase;

namespace CharityTestCore.Service.UserManagment
{
    public interface IUserService
    {
        bool ChangePassword(string username, string oldPassword, string newPassword );
        User? Authenticate(string username, string password );
        Guid? AddUser(string username, string password, string name, string family, string role, string nationalcode,string mobile);
        UserProfileModel? GetProfile(string username);
		 List<UserProfileModel> GetAllUser();
		 UserProfileModel GetById(string Id);
        int CountNationalNumber(string code);
		int CountMobile(string code);
		int CountUserName(string code);
        bool EditUser(Models.UserListModel userListModel);

        UserListModel? GetByIdUserListModel(string Id);

	}
}
