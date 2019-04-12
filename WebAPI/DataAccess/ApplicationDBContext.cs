using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebAPI.Models;

namespace WebAPI.DataAccess
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Person> Person { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<EducationExperience> EducationExperience { get; set; }
        public DbSet<Address> Address { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlite("Data Source=HobbyProject.db");
        //    base.OnConfiguring(optionsBuilder);
        //}
        public ApplicationDBContext() : base("name=ApplicationDBContext")
        {
            Database.SetInitializer(new ApplicationDBInitializer());
        }
    }
}