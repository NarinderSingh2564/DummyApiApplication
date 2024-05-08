using DummyApiApplication.Web.Data.DbClasses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DummyApiApplication.Web.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext()
        {
        }

        public DbSet<User> tblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J96KAUR\\SQLEXPRESS1;Database=DummyDb;Trusted_Connection=false;TrustServerCertificate=true;Integrated Security=true;");
        }

    }
}
