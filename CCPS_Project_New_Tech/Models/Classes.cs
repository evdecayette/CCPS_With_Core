using System.ComponentModel.DataAnnotations;

namespace CCPS_Project_New_Tech.Models
{
    public class Classes
    {
        [Key]
        public int ClasseID { get; set; }
        public string? NomClasse { get; set; }
        public int NiveauClasse { get; set; }
        public string? Categorie { get; set; }
        public string? Description { get; set; }
    }
}
