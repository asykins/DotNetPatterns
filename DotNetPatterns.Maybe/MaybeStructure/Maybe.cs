using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Maybe.MaybeStructure
{
    public class Maybe<T> : IEnumerable<T>
    {
        private readonly IMaybeState<T> _maybeState;

        readonly IEnumerable<T> Content;

        private Maybe(IEnumerable<T> content, IMaybeState<T> maybeState)
        {
            this._maybeState = maybeState;
            this.Content = content;
        }

        public static Maybe<T> Some(T content)
            => new Maybe<T>(new T[] { content }, new Some<T>());

        public static Maybe<T> None()
            => new Maybe<T>(new T[0], new None<T>());

        public Maybe<T> WhenSome(Action<T> action)
        {
            _maybeState.WhenSome(Content, action);
            return this;
        }

        public Maybe<T> WhenNone(Action action)
        {
            _maybeState.WhenNone(action);
            return this;
        }

        public IEnumerator<T> GetEnumerator()
            => Content.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
        private bool HasSome() => Content.Any();

        public static implicit operator Maybe<T>(T content)
            => content == null ? None() : Some(content);
    }
}
