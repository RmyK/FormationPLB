using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int affichageSaison = int.Parse(Console.ReadLine());
            Saison saison = (Saison)affichageSaison;

            Console.WriteLine(saison.ToString());

            switch (saison)
            {
                case Saison.Printemps:
                    Console.WriteLine("Il pleut");
                    break;
                case Saison.Ete:
                    Console.WriteLine("Il fait beau");
                    break;
                case Saison.Automne:
                    Console.WriteLine("Les feuilles tombent");
                    break;
                case Saison.Hiver:
                    Console.WriteLine("Il neige");
                    break;
                default:
                    break;
            }


            //Notation bianire en C#
            string saisonVet = ((SaisonVetement)5).ToString();

            Console.WriteLine(saisonVet);

            Console.Read();
        }
    }

    public enum Saison
    {
        Printemps = 10,
        Ete = 20,
        Automne,
        Hiver
    }

    [Flags]
    public enum SaisonVetement
    {
        Printemps = 1,
        Ete = 2,
        Automne = 4,
        Hiver = 8
    }
}
