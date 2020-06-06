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
        IEnumerable<T> Content;

        private Maybe(IEnumerable<T> content)
        {
            this.Content = content;
        }

        public static Maybe<T> Some(T content)
            => new Maybe<T>(new T[] { content });

        public static Maybe<T> None()
            => new Maybe<T>(new T[0]);

        public IEnumerator<T> GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
