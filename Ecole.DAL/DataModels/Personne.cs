using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    public abstract class Personne
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Nom { get; set; }
        [MaxLength(100)]
        [Required]
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int EcoleId { get; set; }
        [ForeignKey(nameof(EcoleId))]
        public Ecole? Ecole { get; set; }
        [NotMapped]
        public int Age
        {
            get
            {
                return (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;
            }
        }

        [NotMapped]
        public int Age2 => (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;

        public int GetAge()
        {
            return (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;
        }

        public virtual string Afficher()
        {
            return $"{Nom} {Prenom} - Age : {Age} ans";
        }
    }
}
