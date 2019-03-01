using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.DataAccess
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<EducationExperience> EducationExperiences { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=HobbyProject.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}