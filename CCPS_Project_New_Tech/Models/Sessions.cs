using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPS_Project_New_Tech.Models
{
    public class Sessions
    {
        [Key]
        public int SessionID { get; set; }
        [ForeignKey("ClasseID")]
        public int ClasseID { get; set; }
        //This personne Id must be a teacher
        [ForeignKey("PersonneID")]
        public int PersonneID { get; set; }
        [Required]
        public int MaxEtudiants { get; set; }
        [Required]
        public string? JourRencontre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCommence { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateFin { get; set; }
        [Required]
        public string? Heures { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int MontantParticipation { get; set; }
        [Required]
        public string? Byusername { get; set; }
        [Required]
        public string? SaleDeClasse { get; set; }
        public int Actif { get; set; }
        public string? Remarque { get; set; }
    }
}
