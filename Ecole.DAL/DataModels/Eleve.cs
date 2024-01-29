using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    //[Table("Eleves")]
    public class Eleve : Personne
    {
        public int Moyenne { get; set; }

        //public override string Afficher()
        //{
        //    return $"{base.Afficher()} Moyenne : {Moyenne}";
        //}

        //public override string ToString()
        //{
        //    return base.Afficher();
        //}

    }
}
