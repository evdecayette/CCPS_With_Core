using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPS_Project_New_Tech.Models
{
    public class Personne
    {
        [Key]
        public int PersonneID { get; set; }
        [Required]
        public string? Nom { get; set; }
        [Required]
        public string? Prenom { get; set; }
        [Required]
        public string? DDN { get; set; }
        [Required]
        public char? Sexe { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? Tel1 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Tel2 { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Adresse { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
        public string? Statut { get; set; }
        public int Etudiant { get; set; } = 0;
        public int Professeur { get; set; } = 0;
        public int AdminStaff { get; set; } = 0;
        [DataType(DataType.Upload)]
        public string? Photo { get; set; }
        [Required]
        public string? UserNameAttribue { get; set; } = "jesus123";
        public string? CreerParUsername { get; set; } = "edecayette";
        [Required]
        public string? NumeroRecu { get; set; }
        [Required]
        public string? EtudiantidPlus { get; set; } = "2000EU";
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreer { get; set; } = DateTime.Now;
        [NotMapped]
        public IEnumerable? ProfList { get; set; }
        [NotMapped]
        public IEnumerable? SelectedProf { get; set; }


    }
}
