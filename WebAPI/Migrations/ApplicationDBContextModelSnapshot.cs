using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAPI.DataAccess;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("WebAPI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("State");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("WebAPI.Models.EducationExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalComment");

                    b.Property<int?>("EduDegree");

                    b.Property<string>("EduField");

                    b.Property<int>("EndDay");

                    b.Property<int>("EndMonth");

                    b.Property<int>("EndYear");

                    b.Property<double>("GPA");

                    b.Property<bool>("IsCurrent");

                    b.Property<int>("PersonId");

                    b.Property<int>("StartDay");

                    b.Property<int>("StartMonth");

                    b.Property<int>("StartYear");

                    b.Property<int?>("UniversityAddressId");

                    b.Property<string>("UniversityName");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("UniversityAddressId");

                    b.ToTable("EducationExperiences");
                });

            modelBuilder.Entity("WebAPI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<int?>("HomeAddressId");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PreferredName");

                    b.HasKey("Id");

                    b.HasIndex("HomeAddressId");

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

                    b.Property<int?>("JobType");

                    b.Property<int>("PersonId");

                    b.Property<string>("PositionHeld");

                    b.Property<int>("StartDay");

                    b.Property<int>("StartMonth");

                    b.Property<int>("StartYear");

                    b.Property<int?>("WorkAddressId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("WorkAddressId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("WebAPI.Models.EducationExperience", b =>
                {
                    b.HasOne("WebAPI.Models.Person")
                        .WithMany("EdcuationExperiences")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Address", "UniversityAddress")
                        .WithMany()
                        .HasForeignKey("UniversityAddressId");
                });

            modelBuilder.Entity("WebAPI.Models.Person", b =>
                {
                    b.HasOne("WebAPI.Models.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId");
                });

            modelBuilder.Entity("WebAPI.Models.WorkExperience", b =>
                {
                    b.HasOne("WebAPI.Models.Person")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Address", "WorkAddress")
                        .WithMany()
                        .HasForeignKey("WorkAddressId");
                });
        }
    }
}
