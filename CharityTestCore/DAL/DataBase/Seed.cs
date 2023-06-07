using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
    public class Seed
    {
        public   void SeedData()
        {
            ParkerCharityContext context = new ParkerCharityContext();
            if (!context.Users.Any())
            {
                var activities = new List<User>
                {
                    new User
                    {
                         Name = "مدیر",
                         Family = "سیستم",
                         NationalNumber = "1234567980",
                         HashPassword = "8hNzZZBdE/TtZAu1CInd70k8G6D5YYAivGvh9k5awwc=",
                         Role = "admin",
                         UserName = "p_admin"

                    }
                };
                 context.Users.AddRangeAsync(activities);
                 context.SaveChangesAsync();
            }
        }
    }
}
