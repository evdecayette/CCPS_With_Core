﻿// <auto-generated />
using System;
using CCPS_Project_New_Tech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CCPS_Project_New_Tech.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211212015905_AddMoreFieldTo_And_CreateNewTable")]
    partial class AddMoreFieldTo_And_CreateNewTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.Annonces", b =>
                {
                    b.Property<int>("AnnonceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnnonceID"), 1L, 1);

                    b.Property<int>("Actif")
                        .HasColumnType("int");

                    b.Property<string>("Annonce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreee")
                        .HasColumnType("datetime2");

                    b.HasKey("AnnonceID");

                    b.ToTable("Annonces");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.Classes", b =>
                {
                    b.Property<int>("ClasseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClasseID"), 1L, 1);

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NiveauClasse")
                        .HasColumnType("int");

                    b.Property<string>("NomClasse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClasseID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.CreerSession", b =>
                {
                    b.Property<int>("CreerSessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreerSessionID"), 1L, 1);

                    b.Property<int>("Actif")
                        .HasColumnType("int");

                    b.Property<string>("Remarque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SessionDateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SessionDateFin")
                        .HasColumnType("datetime2");

                    b.HasKey("CreerSessionID");

                    b.ToTable("CreerSessions");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.EtudiantsCourants", b =>
                {
                    b.Property<int>("EtudiantsCourantsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EtudiantsCourantsID"), 1L, 1);

                    b.Property<int>("Admis")
                        .HasColumnType("int");

                    b.Property<string>("AdmisPar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreeParUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdmis")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreee")
                        .HasColumnType("datetime2");

                    b.Property<int>("LockEdit")
                        .HasColumnType("int");

                    b.Property<int>("PersonneID")
                        .HasColumnType("int");

                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.HasKey("EtudiantsCourantsID");

                    b.ToTable("EtudiantsCourants");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.HeuresDeClasses", b =>
                {
                    b.Property<int>("HeureDeClasseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeureDeClasseID"), 1L, 1);

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleDeClasse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HeureDeClasseID");

                    b.ToTable("HeuresClasse");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.JoursDeClasses", b =>
                {
                    b.Property<int>("JourID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JourID"), 1L, 1);

                    b.Property<string>("JourDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JourID");

                    b.ToTable("JoursDeClasses");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.Personne", b =>
                {
                    b.Property<int>("PersonneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonneID"), 1L, 1);

                    b.Property<int>("AdminStaff")
                        .HasColumnType("int");

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreerParUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreer")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Etudiant")
                        .HasColumnType("int");

                    b.Property<string>("EtudiantidPlus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroRecu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Professeur")
                        .HasColumnType("int");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Tel1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNameAttribue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonneID");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.SalleDeClasses", b =>
                {
                    b.Property<int>("SalleDeClasseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalleDeClasseID"), 1L, 1);

                    b.Property<string>("NomDuSalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreDePersonne")
                        .HasColumnType("int");

                    b.Property<string>("SalleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalleDeClasseID");

                    b.ToTable("SalleDeClasses");
                });

            modelBuilder.Entity("CCPS_Project_New_Tech.Models.Sessions", b =>
                {
                    b.Property<int>("SessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionID"), 1L, 1);

                    b.Property<int>("Actif")
                        .HasColumnType("int");

                    b.Property<string>("Byusername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClasseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCommence")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Heures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JourRencontre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxEtudiants")
                        .HasColumnType("int");

                    b.Property<int>("MontantParticipation")
                        .HasColumnType("int");

                    b.Property<string>("Remarque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleDeClasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SessionID");

                    b.ToTable("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
