using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    [Table("Administratifs")]
    public class Administratif : Personne, ISalarie
    {
        public int? FonctionId { get; set; }
        [ForeignKey(nameof(FonctionId))]
        public Fonction? Fonction { get; set; }

        [Range(1000, 100000)]
        public decimal Salaire { get; set; }

        public override string Afficher()
        {
            return $"{base.Afficher()} Service : {Fonction.Service} - Fonction : {Fonction.Libelle}";
        }
    }
}
