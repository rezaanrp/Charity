﻿using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
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
  
    public class ParkerCharityContext : DbContext, IDataProtectionKeyContext
    {
        //public ParkerCharityContext(DbContextOptions<ParkerCharityContext> options) : base(options)
        //{

        //}
        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; } = null!;

        public DbSet<User> Users { get; set; }
        public DbSet<EptQuestionList> EptQuestion { get; set; }
        public DbSet<mGenGroup> mGenGroup { get; set; }
        public DbSet<MBTIQuestionList> MBTIQuestionList { get; set; }
        public DbSet<MBTIAnswerList> MBTIAnswerList { get; set; }
        public DbSet<EptQuiz> EptQuiz { get; set; }

		public DbSet<QuizQuestionDisc> QuizQuestionDiscs { get; set; }
		public DbSet<QuizAnswernDisc> QuizAnswernDiscs { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //   base.OnConfiguring(optionsBuilder);
           // optionsBuilder.UseSqlServer(@"Data Source=172.25.42.55;TrustServerCertificate=True;Initial Catalog=ca8_db;User ID=sa;Password=kjhkj@56654ggfd");
           // optionsBuilder.UseSqlServer(@"Data Source=.;TrustServerCertificate=True;Initial Catalog=quizmehr;User ID=mehr;Password=bxvN~21112222");
            optionsBuilder.UseSqlServer(@"Data Source=172.25.42.55;TrustServerCertificate=True;Initial Catalog=ca7_db;User ID=sa;Password=R@y@23.60");

            //     "DefaultConnection": "Data Source=.;TrustServerCertificate=True;Initial Catalog=quizmehr;User ID=sa;Password=kjhkj@56654ggfd"


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasQueryFilter(a => !a.IsDelete);
            modelBuilder.Entity<EptQuestionList>().HasQueryFilter(a => !a.IsDelete);
            modelBuilder.Entity<MBTIAnswerList>().HasQueryFilter(a => !a.IsDelete);
            modelBuilder.Entity<EptQuestionList>().Property(b => b.CreatedDate).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<MBTIAnswerList>().Property(b => b.CreatedDate).HasDefaultValueSql("getdate()");

			// تعریف ارتباطات
			modelBuilder.Entity<QuizAnswernDisc>()
				.HasOne(a => a.QuizQuestion)
				.WithMany(q => q.QuizAnswers)
				.HasForeignKey(a => a.QuizQuestionDiscId);

			new Seed(modelBuilder).seeduser();
            new Seed(modelBuilder).SeedMbtiAnswer();
            new Seed(modelBuilder).SeedDisc();
			modelBuilder.Entity<User>().HasIndex(u => u.NationalNumber).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            ParkerCharityContext s = new ParkerCharityContext();


        }
           
        //Database.Migrate();


    }
}
