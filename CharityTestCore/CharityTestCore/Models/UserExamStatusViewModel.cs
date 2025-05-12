namespace CharityTestCore.Models
{
    public class UserExamStatusViewModel
    {
        public Guid Id { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }
        public string? RepeatPassword { get; set; }
        public string? Role { get; set; }

        public string? Name { get; set; }


        public string? Family { get; set; }
        public string? FullName => Name??"" + " " + Family??"";

        public string? NationalNumber { get; set; }

        public string? MobileNumber { get; set; }

        public string? MbtiResult { get; set; }
        public string? EPTResult { get; set; }

        public string? HasMBTIText => HasMBTI == true ? "دارد" : "ندارد";
        public string? HasEPTText => HasEPT == true ? "دارد" : "ندارد";

        public bool HasMBTI { get; set; }
        public bool HasEPT { get; set; }
    }

}
