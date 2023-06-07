using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharityTestCore.Models
{

    public class EPTQuestion
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "لطفا نام  را وارد کنید")]
        [Display(Name = "نام ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد کنید")]
        [Display(Name = "نام خانوادگی ")]
        public string Family { get; set; }

        [Required(ErrorMessage = "لطفا کد ملی را وارد کنید")]
        [RegularExpression(@"^([0-9]){10}$", ErrorMessage = "کد ملی صحیح نمی باشد")]
        [Display(Name = "کد ملی  ")]
        public string NationalCode { get; set; }

        [Required(ErrorMessage = "لطفا شماره موبایل را وارد کنید")]
        [RegularExpression(@"09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}", ErrorMessage = "شماره موبایل صحیح نمی باشد")]
        [Display(Name = "شماره موبایل ")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "لطفا سن را وارد کنید")]
        [Display(Name = "سن")]
        public int Age { get; set; }

        public bool? HaveSkill { get; set; }
        public bool? BeforeYouHaveJob { get; set; }
        public bool? DoYouWantHaveJob { get; set; }

        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S01 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S02 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S03 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S04 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S05 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S06 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S07 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S08 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S09 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S10 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S11 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S12 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S13 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S14 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S15 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S16 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S17 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S18 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S19 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S20 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S21 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S22 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S23 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S24 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S25 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S26 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S27 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S28 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S29 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S30 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S31 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S32 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S33 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S34 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S35 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S36 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S37 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S38 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S39 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S40 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S41 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S42 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S43 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S44 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S45 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S46 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S47 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S48 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S49 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S50 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S51 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S52 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S53 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S54 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S55 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S56 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S57 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S58 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S59 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S60 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S61 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S62 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S63 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S64 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S65 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S66 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S67 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S68 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S69 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S70 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S71 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S72 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S73 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S74 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S75 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S76 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S77 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S78 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S79 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S80 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S81 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S82 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S83 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S84 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S85 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S86 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S87 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S88 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S89 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S90 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S91 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S92 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S93 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S94 { get; set; }
        [Required(ErrorMessage = "لطفا گزینه  را انتخاب کنید")]
        [Display(Name = "سوال ")]
        public byte S95 { get; set; }
        [Column(Order = 0)]
        public string? Result { get; }
    }

}
