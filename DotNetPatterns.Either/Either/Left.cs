using System;
using System.Linq;

namespace DotNetPatterns.Either.Either
{
    public class Left<TLeft, TRight> : Either<TLeft, TRight>
    {
        private readonly TLeft left;

        public Left(TLeft left) => (this.left) = (left);

        public override IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func)
            => new Left<TLeft, TNewRight>(this.left);

        public override TRight Reduce(Func<TLeft, TRight> func)
            => func(this.left);

        public override IEither<TLeft, TRight> Reduce(Func<TLeft, TRight> func, Func<TLeft, bool> predicate)
            => predicate(this.left) 
                ? new Right<TLeft, TRight>(func(left)) 
            : new Left<TLeft, TRight>(left) as IEither<TLeft, TRight>;
    }
}
