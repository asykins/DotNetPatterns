﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Either.Either
{
    public abstract class Either<TLeft, TRight> : IEither<TLeft, TRight>
    {
        protected readonly TLeft left;
        protected readonly TRight right;

        protected Either(TLeft left) => (this.left) = (left);

        protected Either(TRight right) => (this.right) = (right);

        public abstract IEither<TLeft, TNewRight> Map<TNewRight>(Func<TRight, TNewRight> func);

        public abstract TRight Reduce<TNewLeft>(Func<TLeft, TRight> func);

        public static implicit operator Either<TLeft, TRight>(TLeft left)
            => new Left<TLeft, TRight>(left);

        public static implicit operator Either<TLeft, TRight>(TRight right)
            => new Right<TLeft, TRight>(right);
    }
}