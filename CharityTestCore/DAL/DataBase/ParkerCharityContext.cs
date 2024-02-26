using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
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
           // optionsBuilder.UseSqlServer(@"Server=.;TrustServerCertificate=True;Initial Catalog=quizmehr;User ID=mehr;Password=bxvN~21112222");
            optionsBuilder.UseSqlServer(@"Data Source=.;TrustServerCertificate=True;Initial Catalog=quizmehr;User ID=mehr;Password=bxvN~21112222");
            // optionsBuilder.UseSqlServer(@"Data Source=.;TrustServerCertificate=True;Initial Catalog=ca7_db;User ID=sa;Password=K500at10");

            //     "DefaultConnection": "Data Source=.;TrustServerCertificate=True;Initial Catalog=quizmehr;User ID=sa;Password=kjhkj@56654ggfd"
           

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasQueryFilter(a => !a.IsDelete);
            modelBuilder.Entity<EptQuestionList>().HasQueryFilter(a => !a.IsDelete);
            modelBuilder.Entity<MBTIAnswerList>().HasQueryFilter(a => !a.IsDelete);

            new Seed(modelBuilder).seeduser();
            modelBuilder.Entity<User>().HasIndex(u => u.NationalNumber).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            ParkerCharityContext s = new ParkerCharityContext();


        }
           
        //Database.Migrate();


    }
}
