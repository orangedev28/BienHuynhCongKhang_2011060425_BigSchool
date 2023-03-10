using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BienHuynhCongKhang_2011060425_Week3.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // truy van du lieu
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}