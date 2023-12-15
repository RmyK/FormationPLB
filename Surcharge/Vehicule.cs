using System;
using System.Collections.Generic;
using System.Text;

namespace Surcharge
{
    class Vehicule
    {
        public int Vitesse { get; set; }

        public virtual void Avancer()
        {
            Console.WriteLine($"Je me déplace à {Vitesse}km/h");
        }

        public void Avancer(int vitesse)
        {
            Vitesse = vitesse;
            Avancer();
        }

        public Vehicule()
        {
            Vitesse = 50;
        }

        public Vehicule(int vitesse)
        {
            Vitesse = vitesse;
        }
    }
}
