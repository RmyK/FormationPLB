using System;

namespace ArbreBinaire
{
    class Program
    {
        static void Main(string[] args)
        {
            var arbre = new Noeud();

            arbre.AddValue(11);
            arbre.AddValue(7);
            arbre.AddValue(1);
            arbre.AddValue(5);
            arbre.AddValue(19);
            arbre.AddValue(3);
            arbre.AddValue(8);

            arbre.Afficher();

            Console.Read();
        }
    }
}
