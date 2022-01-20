using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CCPS_Project_New_Tech.Models
{
    public class CreerSession
    {
        [Key]
        public int CreerSessionID { get; set; }
        [DataType(DataType.Date)]
        public DateTime SessionDateDebut { get; set; }
        [DataType(DataType.Date)]
        public DateTime SessionDateFin { get; set; }
        [Required]
        public int Actif { get; set; } = 1;
        public string? Remarque { get; set; }
    }
}
