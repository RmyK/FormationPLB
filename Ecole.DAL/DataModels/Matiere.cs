using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    public class Matiere
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Libelle { get; set; }
        [Range(1,10)]
        public int Coefficient { get; set; }
    }
}
