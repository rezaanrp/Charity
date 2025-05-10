using CharityTestCore.Tools;
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

        public DateTime? CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public string? CreatedDateFarsi => csShamciToMiladi.MiladiToShamsi(CreatedDate);
        public string? LastLoginDateFarsi => csShamciToMiladi.MiladiToShamsi(LastLoginDate);
        public string? FullName
        {
            get { return Name + " " + Family; }
        }

    }
}
