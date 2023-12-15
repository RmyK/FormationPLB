using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbreBinaire
{
    class Noeud
    {
        public int? Value { get; set; }
        public Noeud Gauche { get; set; }
        public Noeud Droite { get; set; }

        public void AddValue(int val)
        {
            if (Value == null)
                Value = val;

            if (Value == val)
                return;

            if (Value > val)
                Droite = new Noeud() { Value = val };
            else
                Gauche = new Noeud() { Value = val };
        }

        public void Afficher()
        {
            if (Droite != null)
                Droite.Afficher();
            Console.WriteLine(Value);
            if (Gauche != null)
                Gauche.Afficher();
        }
    }
}
