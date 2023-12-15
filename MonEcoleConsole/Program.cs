using System;
using MonEcole.BL;

namespace MonEcoleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EcoleService ecoleService = new EcoleService();
            Console.WriteLine("Hello World!");

            ecoleService.AfficherMembreEcole();

            if (true)
                goto ceciestunlabel;

            ceciestunlabel:

            var str = "Hello";
        }

    }
}
