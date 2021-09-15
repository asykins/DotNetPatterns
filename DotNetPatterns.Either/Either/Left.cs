﻿using System;

namespace DotNetPatterns.Either.Either
{
    public class Left<TLeft, TRight> : Either<TLeft, TRight>
    {
        public Left(TLeft left): base(left) { }

        public override IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func)
            => new Left<TLeft, TNewRight>(this.left);

        public override TRight Reduce<TNewLeft>(Func<TLeft, TRight> func)
            => func(this.left);
    }
}