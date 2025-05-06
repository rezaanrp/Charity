using System.ComponentModel.DataAnnotations;

namespace CharityTestCore.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [MinLength(5, ErrorMessage = "نام کاربری حداقل باید پنج کاراکتر باشد")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "لطفا رمز خود را وارد کنید")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "رمز باید حداقل 8 رقم، و دارای حداقل یک حرف، یک عدد و یک کاراکتر ویژه باشد")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
    }

}
