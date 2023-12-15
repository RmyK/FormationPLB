using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Eleve
    {
        private int note;

        public int GetNote()
        {
            return note;
        }

        public void SetNote(int nte)
        {
            if (nte >= 0 && nte <= 20)
                note = nte;
            else
                throw new ArgumentException("la note doit être comprise entre 0 et 20");
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age >= 8 && age <= 12)
                    age = value;
                else
                    throw new ArgumentException("l'eleve n'a pas le bon age pour cette école");
            }
        }

        public string Nom { get; private set; }

        public Eleve(string nom)
        {
            Nom = nom;
        }


        private void DoSomething()
        { }

    }
}
