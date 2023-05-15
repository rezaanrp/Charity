using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
    public class EptQuestionList
    {
        [Key]
        public int x_ { get; set; }
        [MaxLength(60)]
        public string xName { get; set; }
        [MaxLength(60)]
        public string xFamily { get; set; }
        [MaxLength(10)]
        public string NationalCode { get; set; }
        [MaxLength(11)]
        public string MobileNumber { get; set; }
        public int? Age { get; set; }
        public bool? HaveSkill { get; set; }
        public bool? BeforeYouHaveJob { get; set; }
        public bool? DoYouWantHaveJob { get; set; }

        public byte S01 { get; set; }
        public byte S02 { get; set; }
        public byte S03 { get; set; }
        public byte S04 { get; set; }
        public byte S05 { get; set; }
        public byte S06 { get; set; }
        public byte S07 { get; set; }
        public byte S08 { get; set; }
        public byte S09 { get; set; }
        public byte S10 { get; set; }
        public byte S11 { get; set; }
        public byte S12 { get; set; }
        public byte S13 { get; set; }
        public byte S14 { get; set; }
        public byte S15 { get; set; }
        public byte S16 { get; set; }
        public byte S17 { get; set; }
        public byte S18 { get; set; }
        public byte S19 { get; set; }
        public byte S20 { get; set; }
        public byte S21 { get; set; }
        public byte S22 { get; set; }
        public byte S23 { get; set; }
        public byte S24 { get; set; }
        public byte S25 { get; set; }
        public byte S26 { get; set; }
        public byte S27 { get; set; }
        public byte S28 { get; set; }
        public byte S29 { get; set; }
        public byte S30 { get; set; }
        public byte S31 { get; set; }
        public byte S32 { get; set; }
        public byte S33 { get; set; }
        public byte S34 { get; set; }
        public byte S35 { get; set; }
        public byte S36 { get; set; }
        public byte S37 { get; set; }
        public byte S38 { get; set; }
        public byte S39 { get; set; }
        public byte S40 { get; set; }
        public byte S41 { get; set; }
        public byte S42 { get; set; }
        public byte S43 { get; set; }
        public byte S44 { get; set; }
        public byte S45 { get; set; }
        public byte S46 { get; set; }
        public byte S47 { get; set; }
        public byte S48 { get; set; }
        public byte S49 { get; set; }
        public byte S50 { get; set; }
        public byte S51 { get; set; }
        public byte S52 { get; set; }
        public byte S53 { get; set; }
        public byte S54 { get; set; }
        public byte S55 { get; set; }
        public byte S56 { get; set; }
        public byte S57 { get; set; }
        public byte S58 { get; set; }
        public byte S59 { get; set; }
        public byte S60 { get; set; }
        public byte S61 { get; set; }
        public byte S62 { get; set; }
        public byte S63 { get; set; }
        public byte S64 { get; set; }
        public byte S65 { get; set; }
        public byte S66 { get; set; }
        public byte S67 { get; set; }
        public byte S68 { get; set; }
        public byte S69 { get; set; }
        public byte S70 { get; set; }
        public byte S71 { get; set; }
        public byte S72 { get; set; }
        public byte S73 { get; set; }
        public byte S74 { get; set; }
        public byte S75 { get; set; }
        public byte S76 { get; set; }
        public byte S77 { get; set; }
        public byte S78 { get; set; }
        public byte S79 { get; set; }
        public byte S80 { get; set; }
        public byte S81 { get; set; }
        public byte S82 { get; set; }
        public byte S83 { get; set; }
        public byte S84 { get; set; }
        public byte S85 { get; set; }
        public byte S86 { get; set; }
        public byte S87 { get; set; }
        public byte S88 { get; set; }
        public byte S89 { get; set; }
        public byte S90 { get; set; }
        public byte S91 { get; set; }
        public byte S92 { get; set; }
        public byte S93 { get; set; }
        public byte S94 { get; set; }
        public byte S95 { get; set; }

        public string FullName
        {
            get { return xName + " " + xFamily; }
        }
    }
}
