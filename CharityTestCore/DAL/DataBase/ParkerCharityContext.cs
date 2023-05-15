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
        public DbSet<News> AllNews { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<EptQuestionList> EptQuestion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //   base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=192.168.15.135;TrustServerCertificate=True;Initial Catalog=ParkerCharityDB;User ID=sa;Password=K500at10");
        }
    }
}
