using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CleaningProjeDB;integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<ClientTestimonial> ClientTestimonials { get; set; }

        public DbSet<ContactInformation> ContactInformations { get; set; }

        public DbSet<ContactUs> ContactUss { get; set; }

        public DbSet<Home> Homes { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Pricing> Pricings { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        //public DbSet<Customer> Customers { get; set; }

        //public DbSet<Master> Masters { get; set; }
    }
}
