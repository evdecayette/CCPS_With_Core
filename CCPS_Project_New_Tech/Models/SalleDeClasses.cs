using System.ComponentModel.DataAnnotations;

namespace CCPS_Project_New_Tech.Models
{
    public class SalleDeClasses
    {
        [Key]
        public int SalleDeClasseID { get; set; }
        public string? NomDuSalle { get; set; }
        public string? SalleDescription { get; set; }
        public int NombreDePersonne { get; set; }
    }
}
