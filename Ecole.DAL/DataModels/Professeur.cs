using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    [Table("Professeurs")]
    public class Professeur : Personne, ISalarie
    {
        public int MatiereId { get; set; }
        [ForeignKey(nameof(MatiereId))]
        public Matiere? Matiere { get; set; }
        public decimal Salaire { get; set; }

        public override string Afficher()
        {
            return $"{base.Afficher()} Matiere : {Matiere.Libelle} - Coefficient : {Matiere.Coefficient}";
        }

    }
}
