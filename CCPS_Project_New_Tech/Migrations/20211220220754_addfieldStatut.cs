using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCPS_Project_New_Tech.Migrations
{
    public partial class addfieldStatut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Statut",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Statut",
                table: "Personnes");
        }
    }
}
