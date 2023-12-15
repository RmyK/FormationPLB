using System;
using System.Linq;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            var mots = new string[] { "voiture", "poule", "arbre", "chenille", "telephone" };

            var rnd = new Random();

            Console.WriteLine("Bienvenu au jeu du pendu !");
            Console.WriteLine("Prêt pour une partie ?");
            Console.WriteLine("Appuyer sur une touche pour démarrer");
            Console.Read();

            ConsoleKeyInfo res;
            do
            {
                Console.WriteLine("C'est partie");
                var motToFind = mots[rnd.Next(0, mots.Length - 1)];
                var motOrigin = motToFind;
                var motTrouve = new char[motToFind.Length];
                for (int i = 0; i < motTrouve.Length; i++)
                {
                    motTrouve[i] = '_';
                }

                int coup = 0;

                do
                {
                    Console.WriteLine($"{GetCurrentMot(motTrouve)} - {motTrouve.Length} lettres ");
                    Console.WriteLine($"{11 - coup} coups restant");
                    Console.WriteLine("Choix une lettre");
                    var saisie = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    while (motToFind.Contains(saisie.ToString()))
                    {
                        var index = motToFind.IndexOf(saisie.ToString());
                        motTrouve[index] = saisie.ToString()[0];
                        motToFind = motToFind.Remove(index, 1);
                        motToFind = motToFind.Insert(index, "#");
                    }
                } while (motTrouve.Contains('_') && coup++ < 11);

                Console.WriteLine(coup < 11 ? "Bravo !" : "Perdu !");
                Console.WriteLine($"Le mot à trouver était {motOrigin}");

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Souhaites-tu faire une nouvelle partie Y/N ?");
                    res = Console.ReadKey();
                    Console.WriteLine();
                } while (res.Key != ConsoleKey.Y && res.Key != ConsoleKey.N);

            } while (res.Key == ConsoleKey.Y);


            string GetCurrentMot(char[] tab)
            {
                var str = "";
                foreach (var c in tab)
                {
                    str = str + c;
                }

                return str;
            }
        }
    }
}
