﻿using CharityTestCore.Models;
using DAL.DataBase;
using DAL.Dtos;

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

        public bool EditUsersList(Models.UserListModel item, string newpassword);
        public bool Delete(User item);
        List<UserExamStatusDtos> GetUsersWithExamStatus();
        void Update(User user);
    }
}
