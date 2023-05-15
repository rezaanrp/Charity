using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
  
    public class ParkerCharityContext : DbContext
    {
        //public ParkerCharityContext(DbContextOptions<ParkerCharityContext> options) : base(options)
        //{

        //}
        public DbSet<User> Users { get; set; }
        public DbSet<EptQuestionList> EptQuestion { get; set; }
        public DbSet<mGenGroup> mGenGroup { get; set; }
        public DbSet<MBTIQuestionList> MBTIQuestionList { get; set; }
        public DbSet<MBTIAnswerList> MBTIAnswerList { get; set; }
        public DbSet<EptQuiz> EptQuiz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //   base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer(@"Server=127.0.0.1;TrustServerCertificate=True;Initial Catalog=ParkerCharityDB;User ID=;Password=");
         //  optionsBuilder.UseSqlServer(@"Server=.;TrustServerCertificate=True;Initial Catalog=ParkerCharityDB;User ID=;Password=");

        }
    }
}
