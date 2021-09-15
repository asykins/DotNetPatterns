using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Either.Either
{
    public interface IEither<TLeft, TRight>
    {
        IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func);
        IEither<TLeft, TRight> Reduce(Func<TLeft, TRight> func, Func<TLeft, bool> predicate);
        TRight Reduce(Func<TLeft, TRight> func);

    }
}
