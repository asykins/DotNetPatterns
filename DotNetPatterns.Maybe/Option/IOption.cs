using System;

namespace DotNetPatterns.Maybe.Option
{
    public interface IOption<T>
    {
        IOption<T> When(Func<T, bool> func);

        T Do(Action<T> action);
    }
}
