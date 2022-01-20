using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCPS_Project_New_Tech.Migrations
{
    public partial class CreateTableSessions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "personneID",
                table: "Personnes",
                newName: "PersonneID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonneID",
                table: "Personnes",
                newName: "personneID");
        }
    }
}
