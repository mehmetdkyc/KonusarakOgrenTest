using KonusarakOgren.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess
{
    public class EntitiesDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-QFIKDEC; Database=EticaretSmallDB; Trusted_Connection=True;");
        }
        public DbSet<Users>? User { get; set; }
        public DbSet<Products>? Product { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<UserInfo>? UserInfos { get; set; }
        public DbSet<Category>? Categories { get; set; }

    }
}
