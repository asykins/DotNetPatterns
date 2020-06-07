using System;
using System.Collections.Generic;

namespace DotNetPatterns.Maybe.MaybeStructure
{
    public interface IMaybeState<T>
    {
        IMaybeState<T> WhenNone(Action action);
        IMaybeState<T> WhenSome(IEnumerable<T> maybeContent, Action<T> action);
    }
}
