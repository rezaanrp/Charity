using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
    public class MBTIQuestionList
    {
        [Key]
        public int Id { get; set; }
        [AllowNull]
        public string Question { get; set; }
        [AllowNull]
        public string Answer1 { get; set; }
        [AllowNull]
        public string Answer2 { get; set; }
        [AllowNull]
        public string Answer3 { get; set; }

    }
}
