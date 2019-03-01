using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAPI.DataAccess;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20190226043208_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("WebAPI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PreferredName");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("WebAPI.Models.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<string>("Duties");

                    b.Property<int>("EndDay");

                    b.Property<int>("EndMonth");

                    b.Property<int>("EndYear");

                    b.Property<bool>("IsCurrent");

                    b.Property<string>("JobType");

                    b.Property<string>("LocationCity");

                    b.Property<string>("LocationCountry");

                    b.Property<int>("LocationZip");

                    b.Property<int>("PersonId");

                    b.Property<string>("PositionHeld");

                    b.Property<int>("StartDay");

                    b.Property<int>("StartMonth");

                    b.Property<int>("StartYear");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("WebAPI.Models.WorkExperience", b =>
                {
                    b.HasOne("WebAPI.Models.Person")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
