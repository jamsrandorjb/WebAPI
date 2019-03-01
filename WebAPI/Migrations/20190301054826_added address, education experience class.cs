using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class addedaddresseducationexperienceclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationCity",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "LocationCountry",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "LocationZip",
                table: "WorkExperiences");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    AdditionalComment = table.Column<string>(nullable: true),
                    EduDegree = table.Column<int>(nullable: true),
                    EduField = table.Column<string>(nullable: true),
                    EndDay = table.Column<int>(nullable: false),
                    EndMonth = table.Column<int>(nullable: false),
                    EndYear = table.Column<int>(nullable: false),
                    GPA = table.Column<double>(nullable: false),
                    IsCurrent = table.Column<bool>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    StartDay = table.Column<int>(nullable: false),
                    StartMonth = table.Column<int>(nullable: false),
                    StartYear = table.Column<int>(nullable: false),
                    UniversityAddressId = table.Column<int>(nullable: true),
                    UniversityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationExperiences_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationExperiences_Addresses_UniversityAddressId",
                        column: x => x.UniversityAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "WorkAddressId",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeAddressId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "People",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobType",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_WorkAddressId",
                table: "WorkExperiences",
                column: "WorkAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_People_HomeAddressId",
                table: "People",
                column: "HomeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationExperiences_PersonId",
                table: "EducationExperiences",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationExperiences_UniversityAddressId",
                table: "EducationExperiences",
                column: "UniversityAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Addresses_HomeAddressId",
                table: "People",
                column: "HomeAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Addresses_WorkAddressId",
                table: "WorkExperiences",
                column: "WorkAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Addresses_HomeAddressId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Addresses_WorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_WorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_People_HomeAddressId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "WorkAddressId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "HomeAddressId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "People");

            migrationBuilder.DropTable(
                name: "EducationExperiences");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "LocationCity",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationCountry",
                table: "WorkExperiences",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationZip",
                table: "WorkExperiences",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "JobType",
                table: "WorkExperiences",
                nullable: true);
        }
    }
}
