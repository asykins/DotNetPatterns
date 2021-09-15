using System;

namespace DotNetPatterns.Either.Either
{
    public class Right<TLeft, TRight> : Either<TLeft, TRight>
    {
        private readonly TRight right;

        public Right(TRight right) => (this.right) = (right);

        public override IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func)
            => new Right<TLeft, TNewRight>(func(right));

        public override TRight Reduce(Func<TLeft, TRight> func)
            => this.right;

        public override IEither<TLeft, TRight> Reduce(Func<TLeft, TRight> func, Func<TLeft, bool> predicate)
            => new Right<TLeft, TRight>(this.right);
    }
}
