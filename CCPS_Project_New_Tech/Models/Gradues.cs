using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPS_Project_New_Tech.Models
{
    public class Gradues
    {
        [Key]
        public int GradueID { get; set; }
        [ForeignKey("ClasseID")]
        public int PersonneID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateGraduation { get; set; }
        public int NbrDiplomeInprime { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateInprime { get; set; }
        [Required]
        public string? Sujet { get; set; }
    }
}
