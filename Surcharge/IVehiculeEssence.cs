using System;
using System.Collections.Generic;
using System.Text;

namespace Surcharge
{
    interface IVehiculeEssence
    {
        public int Carburant { get; set; }

        void AjouterCarburant(int volCarburant)
        {
            Carburant += volCarburant;
        }
    }
}
