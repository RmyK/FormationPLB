using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonEcole.DAL.DataModels;

namespace MonEcole.BL
{
    public class EcoleService
    {
        private Ecole monEcole;

        public void Embaucher(ISalarie salarie)
        {
            monEcole.Personnes.Add((Personne)salarie);
        }

        public void Inscrire(Eleve eleve)
        {
            monEcole.Personnes.Add(eleve);
        }

        public void AfficherMembreEcole()
        {
            foreach (var pers in monEcole.Personnes)
            {
                Console.WriteLine(pers.Afficher());
            }
        }

        public EcoleService()
        {
            monEcole = new Ecole();
        }
    }
}
