using System.ComponentModel.DataAnnotations;

namespace CharityTestCore.Models
{
    public class UserListModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string HashPassword { get; set; }
        public string Role { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string NationalNumber { get; set; }

    }
}
