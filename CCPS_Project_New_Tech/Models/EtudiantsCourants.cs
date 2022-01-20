using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPS_Project_New_Tech.Models
{
    public class EtudiantsCourants
    {
        [Key]
        public int EtudiantsCourantsID { get; set; }
        [ForeignKey("ClasseID")]
        public int PersonneID { get; set; }
        [ForeignKey("ClasseID")]
        public int SessionID { get; set; }
        public DateTime DateCreee { get; set; }
        public int Admis { get; set; }
        [Required]
        public string? AdmisPar { get; set; }
        public int LockEdit { get; set; }
        public DateTime DateAdmis { get; set; }
        public string? CreeParUsername { get; set; }
    }
}
