using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> arts = new List<Article>();

            var artCher = GetArticleCondition(arts, (Article a)=>(a.Prix>=100));
            var artNombreux = GetArticleCondition(arts, (Article a)=> (a.Quantite>=100));
            var artNombreux2 = GetIfCondition(arts, (Article a) => (a.Quantite >= 100));
            var artNombreux3 = arts.GetIfCondition((Article a) => (a.Quantite >= 100));
            arts.Where(a => a.Quantite >= 100);
        }

        public List<Article> GetArticleCher(List<Article> articles)
        {
            List<Article> artsCher = new List<Article>();

            foreach (var art in articles)
            {
                if (art.Prix >= 100)
                    artsCher.Add(art);
            }
            return artsCher;
        }

        public List<Article> GetArticleSupPrix(List<Article> articles, int prixMax)
        {
            List<Article> artsCher = new List<Article>();

            foreach (var art in articles)
            {
                if (art.Prix >= prixMax)
                    artsCher.Add(art);
            }
            return artsCher;
        }

        public static List<Article> GetArticleCondition(List<Article> articles,Func<Article,bool> fct)
        {
            List<Article> artsCher = new List<Article>();

            foreach (var art in articles)
            {
                if (fct(art))
                    artsCher.Add(art);
            }
            return artsCher;
        }

        public static IEnumerable<T> GetIfCondition<T>(IEnumerable<T> items, Func<T, bool> fct)
        {
            foreach (var art in items)
                if (fct(art))
                    yield return art;
        }

    }
}
