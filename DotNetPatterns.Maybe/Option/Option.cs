using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Maybe.Option
{
    public abstract class Option<T> : IOption<T>
    {
        protected readonly T[] contents;

        protected Option(T content)
        {
            contents = new T[] { content };
        }

        public abstract T Do(Action<T> action);

        public abstract IOption<T> When(Func<T, bool> func);

        public static implicit operator Option<T>(T content)
            => content == null ? new None<T>() : new Some<T>(content) as Option<T>;
    }
}
