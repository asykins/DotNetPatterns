
using System;
using System.Collections.Generic;

namespace DotNetPatterns.Maybe.MaybeStructure
{
    public class Some<T> : IMaybeState<T>
    {
        public IMaybeState<T> WhenNone(Action action) 
            => this;

        public IMaybeState<T> WhenSome(IEnumerable<T> maybeContent, Action<T> action)
        {
            foreach (var content in maybeContent)
                action(content);
            return this;
        }
    }
}
