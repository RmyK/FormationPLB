using System;
using System.Collections.Generic;

namespace GestionStock
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> arts = new List<Article>();

            while (true)
            {
                try
                {
                    Article art = new Article();
                    Console.WriteLine("Nom de l'article");
                    art.Nom = Console.ReadLine();
                    Console.WriteLine("Prix de l'article");
                    bool valOk = false;
                    while (!valOk)
                    {
                        try
                        {
                            art.Prix = Convert.ToDecimal(Console.ReadLine());
                            valOk = true;
                        }
                        catch (FormatException ex)
                        {
                            throw new SaisiePrixException("Le prix saisie n'est pas bon", ex);
                        }
                    }
                    Console.WriteLine("Quantité de l'article");
                    art.Qte = int.Parse(Console.ReadLine());
                    Console.WriteLine("Article : " + art.Nom + " prix total : " + art.Qte * art.Prix);
                    Console.WriteLine(string.Format("Article : {0} | prix total {1}", art.Nom, art.Prix * art.Qte));
                    Console.WriteLine($"Article : {art.Nom} prix total : {art.Qte * art.Prix}");

                    arts.Add(art);

                    ConsoleKeyInfo res;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Souhaitez-vous ajouter un nouvel article Y/N ?");
                        res = Console.ReadKey();
                        Console.WriteLine();
                    } while (res.Key != ConsoleKey.Y && res.Key != ConsoleKey.N);
                    if (res.Key == ConsoleKey.N)
                        break;
                }
                catch (SaisiePrixException)
                {
                    Console.WriteLine("Le prix doit être une valeur numérique");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une exception a eu lieue, veuillez recommencer la saisie");
                }


                foreach (Article article in arts)
                {
                    Console.WriteLine($"{article.Nom} - Prix total :{article.Prix * article.Qte}");
                }
                //string escapeStr = @"";
                //string interpolNEscape = $@"{art.Nom}";
            }
        }
    }
}
