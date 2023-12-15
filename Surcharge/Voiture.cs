using System;
using System.Collections.Generic;
using System.Text;

namespace Surcharge
{
    class Voiture : Vehicule, IVehiculeEssence
    {
        public int Carburant { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Avancer()
        {
            Console.WriteLine($"Je roule à {Vitesse}km/h");
        }

        public Voiture()
        {
        }

        public Voiture(int vitesse) : base(vitesse)
        {
        }
    }
}
