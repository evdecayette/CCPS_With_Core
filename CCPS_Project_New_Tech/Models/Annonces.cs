using System.ComponentModel.DataAnnotations;

namespace CCPS_Project_New_Tech.Models
{
    public class Annonces
    {
        [Key]
        public int AnnonceID { get; set; }
        [Required]
        public string? Annonce { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreee { get; set; }
        public int Actif { get; set; }
    }
}
