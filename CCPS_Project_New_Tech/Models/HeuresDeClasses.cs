using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPS_Project_New_Tech.Models
{
    public class HeuresDeClasses
    {
        [Key]
        public int HeureDeClasseID { get; set; }
        public string? Horaire { get; set; }
        [ForeignKey("Classename")]
        public string? SaleDeClasse { get; set; }
        public string? Categorie { get; set; }
    }
}
