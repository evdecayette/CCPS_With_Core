using CCPS_Project_New_Tech.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;

namespace CCPS_Project_New_Tech.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Sessions> Sessions { get; set; }
        public DbSet<EtudiantsCourants> EtudiantsCourants { get; set; }
        public DbSet<CreerSession> CreerSessions { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<HeuresDeClasses> HeuresClasse { get; set; }
        public DbSet<JoursDeClasses> JoursDeClasses { get; set; }
        public DbSet<SalleDeClasses> SalleDeClasses { get; set; }
        public DbSet<Annonces> Annonces { get; set; }
        public DbSet<Gradues> Gradues { get; set; }

    }
}
 