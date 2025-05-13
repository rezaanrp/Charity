using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class mGenGroup
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Group { get; set; }
        [Required]
        public string Value { get; set; }
        [MaxLength(200)]
        [AllowNull]
        public string? Comment { get; set; }
    }

}
