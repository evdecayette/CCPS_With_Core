using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCPS_Project_New_Tech.Migrations
{
    public partial class AddMoreFieldTo_And_CreateNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SaleDeClasse",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AdminStaff",
                table: "Personnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreerParUsername",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Etudiant",
                table: "Personnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EtudiantidPlus",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroRecu",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pays",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Professeur",
                table: "Personnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sexe",
                table: "Personnes",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tel1",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tel2",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNameAttribue",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ville",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Annonces",
                columns: table => new
                {
                    AnnonceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Annonce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actif = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annonces", x => x.AnnonceID);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClasseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomClasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NiveauClasse = table.Column<int>(type: "int", nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClasseID);
                });

            migrationBuilder.CreateTable(
                name: "CreerSessions",
                columns: table => new
                {
                    CreerSessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionDateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionDateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actif = table.Column<int>(type: "int", nullable: false),
                    Remarque = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreerSessions", x => x.CreerSessionID);
                });

            migrationBuilder.CreateTable(
                name: "EtudiantsCourants",
                columns: table => new
                {
                    EtudiantsCourantsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonneID = table.Column<int>(type: "int", nullable: false),
                    SessionID = table.Column<int>(type: "int", nullable: false),
                    DateCreee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Admis = table.Column<int>(type: "int", nullable: false),
                    AdmisPar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockEdit = table.Column<int>(type: "int", nullable: false),
                    DateAdmis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreeParUsername = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtudiantsCourants", x => x.EtudiantsCourantsID);
                });

            migrationBuilder.CreateTable(
                name: "HeuresClasse",
                columns: table => new
                {
                    HeureDeClasseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horaire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleDeClasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeuresClasse", x => x.HeureDeClasseID);
                });

            migrationBuilder.CreateTable(
                name: "JoursDeClasses",
                columns: table => new
                {
                    JourID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JourDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoursDeClasses", x => x.JourID);
                });

            migrationBuilder.CreateTable(
                name: "SalleDeClasses",
                columns: table => new
                {
                    SalleDeClasseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomDuSalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreDePersonne = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalleDeClasses", x => x.SalleDeClasseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annonces");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "CreerSessions");

            migrationBuilder.DropTable(
                name: "EtudiantsCourants");

            migrationBuilder.DropTable(
                name: "HeuresClasse");

            migrationBuilder.DropTable(
                name: "JoursDeClasses");

            migrationBuilder.DropTable(
                name: "SalleDeClasses");

            migrationBuilder.DropColumn(
                name: "SaleDeClasse",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "AdminStaff",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "CreerParUsername",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Etudiant",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "EtudiantidPlus",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "NumeroRecu",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Pays",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Professeur",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Sexe",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Tel1",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Tel2",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "UserNameAttribue",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "Ville",
                table: "Personnes");
        }
    }
}
