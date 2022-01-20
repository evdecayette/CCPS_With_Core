using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCPS_Project_New_Tech.Migrations
{
    public partial class addTableDesGradues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonneID",
                table: "Sessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gradues",
                columns: table => new
                {
                    GradueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonneID = table.Column<int>(type: "int", nullable: false),
                    DateGraduation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NbrDiplomeInprime = table.Column<int>(type: "int", nullable: false),
                    DateInprime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradues", x => x.GradueID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gradues");

            migrationBuilder.DropColumn(
                name: "PersonneID",
                table: "Sessions");
        }
    }
}
