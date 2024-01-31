using System.ComponentModel.DataAnnotations;

namespace CharityTestCore.Models
{
    public class UserListModel
    {
        public Guid Id { get; set; }

        [MaxLength(60)]
        [MinLength(5,ErrorMessage ="حداقل طول نام کاربری 5 کاراکتر می باشد")]
		[Required(ErrorMessage ="وارد کردن نام کاربری اجباری می باشد")]
        public string UserName { get; set; }

        [MaxLength(20)]
		[Required(ErrorMessage = "لطفا رمز خود را وارد کنید")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "رمز باید حداقل 8 رقم، و دارای حداقل یک حرف، یک عدد و یک کاراکتر ویژه باشد")]
		[DataType(DataType.Password)]
		[Display(Name = "رمز عبور")]
		public string Password { get; set; }
		[MaxLength(20)]
		[Required(ErrorMessage = "لطفا رمز خود را وارد کنید")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "رمز باید حداقل 8 رقم، و دارای حداقل یک حرف، یک عدد و یک کاراکتر ویژه باشد")]
		[DataType(DataType.Password)]
		[Display(Name = "رمز عبور")]
		public string RepeatPassword { get; set; }
		[MaxLength(30)]
        public string Role { get; set; }

        [MaxLength(30)]
		[Required(ErrorMessage = " وارد کردن نام اجباری می باشد")]

		public string Name { get; set; }

        [MaxLength(30)]
		[Required(ErrorMessage = " وارد کردن نام خانوادگی اجباری می باشد")]

		public string Family { get; set; }

        [StringLength(10)]
		[Required(ErrorMessage = " وارد کردن  کد ملی اجباری می باشد")]

		public string NationalNumber { get; set; }

        [StringLength(11)]
		[Required(ErrorMessage = " وارد کردن شماره تماس اجباری می باشد")]

		public string MobileNumber { get; set; }


        public string FullName
        {
            get { return Name + " " + Family; }
        }

    }
}
