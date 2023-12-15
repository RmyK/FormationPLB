using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> GetIfCondition<T>(this IEnumerable<T> items, Func<T, bool> fct)
        {
            foreach (var art in items)
                if (fct(art))
                    yield return art;
        }
    }
}
