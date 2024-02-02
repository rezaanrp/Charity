using System.ComponentModel.DataAnnotations;

namespace CharityTestCore.Models
{
    public class UserProfileModel
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Role { get; set; }
		public string? Name { get; set; }
		public string? Family { get; set; }
		public string? NationalNumber { get; set; }
		public string? MobileNumber { get; set; }
        public string? FullName
        {
            get { return Name + " " + Family; }
        }

    }
}
