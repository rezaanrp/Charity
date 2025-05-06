using System.ComponentModel.DataAnnotations;

namespace DAL.Dtos
{
    public class UserExamStatusDtos
    {
        public Guid Id { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }
        public string? RepeatPassword { get; set; }
        public string? Role { get; set; }

        public string? Name { get; set; }


        public string? Family { get; set; }

        public string? NationalNumber { get; set; }

        public string? MobileNumber { get; set; }

  

        public bool HasMBTI { get; set; }
        public bool HasEPT { get; set; }
    }

}
