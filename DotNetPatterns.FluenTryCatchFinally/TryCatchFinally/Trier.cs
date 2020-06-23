using DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces;
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

        public static ICatcherOrRethrower<T, TResult> Try(T content, Func<T, TResult> tryFunc)
        {
            if(content == null)
            {
                return new InitialCatcher<T, TResult>(content, NullTry);
            }
            else
            {
                return new InitialCatcher<T, TResult>(content, tryFunc);
            }
        }
    }
}
