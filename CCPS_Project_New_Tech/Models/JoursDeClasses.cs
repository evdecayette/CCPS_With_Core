using System.ComponentModel.DataAnnotations;

namespace CCPS_Project_New_Tech.Models
{
    public class JoursDeClasses
    {
        [Key]
        public int JourID { get; set; }
        public string? JourDescription { get; set; }
    }
}
