using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string UserName { get; set; }


        [MaxLength(60)]
        public string HashPassword { get; set; }
        [MaxLength(30)]
        public string Role { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Family { get; set; }

        [StringLength(10)]
        public string NationalNumber { get; set; }

        [StringLength(11)]
        public string MobileNumber { get; set; }

        public bool IsDelete { get; set; } = false;

        public DateTime CreatedDate { get; set; } 
        public DateTime? LastLoginDate { get; set; }

        public string FullName
        {
            get { return Name + " " + Family; }
        }
    }
}
