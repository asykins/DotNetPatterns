using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class Trier<T, TResult>
    {
        private static Func<T, TResult> NullTry
            => (T content) => throw new ArgumentNullException(nameof(content));

        public static Catcher<T, TResult> Try(T content, Func<T, TResult> tryFunc)
        {
            if(content == null)
            {
                return new Catcher<T, TResult>(content, NullTry);
            }
            else
            {
                return new Catcher<T, TResult>(content, tryFunc);
            }
        }
    }
}
