using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCPS_Project_New_Tech.Migrations
{
    public partial class FixSessionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClasseID = table.Column<int>(type: "int", nullable: false),
                    MaxEtudiants = table.Column<int>(type: "int", nullable: false),
                    JourRencontre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCommence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantParticipation = table.Column<int>(type: "int", nullable: false),
                    Byusername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actif = table.Column<int>(type: "int", nullable: false),
                    Remarque = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
