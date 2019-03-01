using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PreferredName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CompanyName = table.Column<string>(nullable: true),
                    Duties = table.Column<string>(nullable: true),
                    EndDay = table.Column<int>(nullable: false),
                    EndMonth = table.Column<int>(nullable: false),
                    EndYear = table.Column<int>(nullable: false),
                    IsCurrent = table.Column<bool>(nullable: false),
                    JobType = table.Column<string>(nullable: true),
                    LocationCity = table.Column<string>(nullable: true),
                    LocationCountry = table.Column<string>(nullable: true),
                    LocationZip = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    PositionHeld = table.Column<string>(nullable: true),
                    StartDay = table.Column<int>(nullable: false),
                    StartMonth = table.Column<int>(nullable: false),
                    StartYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_PersonId",
                table: "WorkExperiences",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
