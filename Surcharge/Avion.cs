using System;
using System.Collections.Generic;
using System.Text;

namespace Surcharge
{
    class Avion : Vehicule
    {
        public override void Avancer()
        {
            Console.WriteLine("Je suis un avion");
            base.Avancer();
        }
    }
}
