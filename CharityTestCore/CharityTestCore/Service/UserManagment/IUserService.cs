﻿using CharityTestCore.Models;
using Domain.Model;

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
		 bool DeleteUser(string Id);
        int CountNationalNumber(string code);
		int CountMobile(string code);
		int CountUserName(string code);
        bool EditUser(Models.UserListModel userListModel);

        UserListModel? GetByIdUserListModel(string Id);
        List<UserExamStatusViewModel> GetAllByQuizUser();
        Task<bool> UpdateProfileAsync(UserProfileModel model, Guid currentUserId);
    }
}
