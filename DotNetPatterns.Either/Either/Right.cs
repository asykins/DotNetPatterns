using System;

namespace DotNetPatterns.Either.Either
{
    public class Right<TLeft, TRight> : Either<TLeft, TRight>
    {
        public Right(TRight right): base(right) { }

        public override IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func)
            => new Right<TLeft, TNewRight>(func(right));

        public override TRight Reduce<TNewLeft>(Func<TLeft, TRight> func)
            => this.right;
    }
}
