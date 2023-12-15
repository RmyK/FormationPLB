using System;
using System.Collections.Generic;

namespace Surcharge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicule> vehicules = new List<Vehicule>();
            Vehicule v = new Vehicule();

            vehicules.Add(v);

            Voiture auto = new Voiture(70);

            Avion avion = new Avion();
            avion.Vitesse = 150;

            IVehiculeEssence AutoEssence = new Voiture();

            Console.WriteLine(((Voiture)AutoEssence).Vitesse);

            vehicules.Add(auto);
            vehicules.Add(avion);

            foreach (var vehic in vehicules)
            {
                vehic.Avancer();
                vehic.Avancer(80);
            }
            Console.Read();
        }
    }
}
