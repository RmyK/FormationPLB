using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    public class Ecole
    {
        public int Id { get; set; }
        [NotMapped]
        public int NbEleve { get; set; }
        [NotMapped]
        public int NbPersonnel { get; set; }
        public List<Personne> Personnes { get; set; }
        public string Nom { get; set; }

    }
}
