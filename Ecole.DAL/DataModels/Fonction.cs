using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonEcole.DAL.DataModels
{
    public class Fonction
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Service { get; set; }
    }
}
