using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoleMVC.Models
{
    public class EleveViewModel : IValidatableObject
    {
        private Eleve monModel { get; set; }

        [Required(ErrorMessage ="Le nom de l'élève est obligatoire")]
        public string Nom
        {
            get => monModel.Nom;
            set => monModel.Nom = value;
        }

        public string Prenom
        {
            get => monModel.Prenom;
            set => monModel.Prenom = value;
        }

        [DisplayName("Date de naissance")]
        public DateTime DateNaissance
        {
            get => monModel.DateNaissance;
            set => monModel.DateNaissance = value;
        }

        [DisplayName("Date de naissance")]
        public string DateNaissanceString => monModel.DateNaissance.ToShortDateString();

        [Range(0,20,ErrorMessage ="La moyenne doit être comprise entre 0 et 20")]
        public int Moyenne
        {
            get => monModel.Moyenne;
            set => monModel.Moyenne = value;
        }

        public string Age => $"{monModel.Age} ans";

        public Eleve GetModel => monModel;

        public EleveViewModel(Eleve eleve)
        {
            monModel = eleve;
        }

        public EleveViewModel()
        {
            monModel = new Eleve() { EcoleId = 1 };
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Nom) || string.IsNullOrWhiteSpace(Prenom))
                yield return new ValidationResult("L'élève doit avoir un nom et un prénom",new string[]{ nameof(Nom), nameof(Prenom) });
        }
    }
}
