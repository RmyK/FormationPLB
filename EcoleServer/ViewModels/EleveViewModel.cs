using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoleServer.ViewModels
{
    public record EleveViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Moyenne { get; set; }
        public int Age => (int)DateTime.Now.Subtract(DateNaissance).TotalDays / 365;

        public EleveViewModel(Eleve eleve)
        {
            Id = eleve.Id;
            Nom = eleve.Nom;
            Prenom = eleve.Prenom;
            DateNaissance = eleve.DateNaissance;
            Moyenne = eleve.Moyenne;
        }
    }
}
