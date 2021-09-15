using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Either.Either
{
    public abstract class Either<TLeft, TRight> : IEither<TLeft, TRight>
    {
        public abstract IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func);

        public abstract TRight Reduce(Func<TLeft, TRight> func);

        public abstract IEither<TLeft, TRight> Reduce(Func<TLeft, TRight> func, Func<TLeft, bool> predicate);

        public static implicit operator Either<TLeft, TRight>(TLeft left)
            => new Left<TLeft, TRight>(left);

        public static implicit operator Either<TLeft, TRight>(TRight right)
            => new Right<TLeft, TRight>(right);
    }
}
