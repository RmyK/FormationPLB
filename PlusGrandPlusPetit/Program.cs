using System;
using System.Threading;

namespace PlusGrandPlusPetit
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var valueFind = rnd.Next(0, 100);
            Console.WriteLine("Bienvenu au plus grand plus petit !");
            Thread.Sleep(2000);
            Console.WriteLine("Sauras-tu deviner en moins de 10 coups le nombre entre 0 et 100 que j'ai pour toi ?");
            Thread.Sleep(2000);

            while (true)
            {
                Console.WriteLine("C'est parti !");

                Console.WriteLine();
                int count = 1;
                int valSaisie;
                do
                {
                    while (true)
                    {
                        Console.WriteLine("Quel nombre choisis-tu ?");
                        var saisie = Console.ReadLine();
                        if (!int.TryParse(saisie, out valSaisie))
                        {
                            Console.WriteLine("Ce n'est pas un nombre");
                            continue;
                        }
                        if (valSaisie > 100 || valSaisie < 0)
                        {
                            Console.WriteLine("Le nombre n'est pas compris entre 0 et 100");
                            continue;
                        }
                        break;
                    }

                    if (valSaisie > valueFind)
                        Console.WriteLine("Plus petit");
                    if (valSaisie < valueFind)
                        Console.WriteLine("Plus grand");

                    Console.WriteLine($"{10 - count++} coups restant");

                } while (valSaisie != valueFind && count <= 10);

                if (valSaisie == valueFind)
                {
                    Console.WriteLine($"Bravo, tu as gagné! Le nombre à trouver était bien {valueFind}");
                }
                else
                {
                    Console.WriteLine($"Dommage, c'est perdu ! Le nombre à trouver était bien {valueFind}");
                }

                ConsoleKeyInfo res;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Souhaites-tu faire une nouvelle partie Y/N ?");
                    res = Console.ReadKey();
                    Console.WriteLine();
                } while (res.Key != ConsoleKey.Y && res.Key != ConsoleKey.N);
                if (res.Key == ConsoleKey.N)
                    break;
            }
        }
    }
}
