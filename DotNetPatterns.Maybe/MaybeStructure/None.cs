using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Maybe.MaybeStructure
{
    public class None<T> : IMaybeState<T>
    {
        public IMaybeState<T> WhenNone(Action action)
        {
            action();
            return this;
        }

        public IMaybeState<T> WhenSome(IEnumerable<T> maybeContent, Action<T> action)
            => this;
    }
}
