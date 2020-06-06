using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Maybe
{
    public static class IEnumerableExtensions
    {
        public static void Do<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach(var item in source)
                action(item);
        }
    }
}
