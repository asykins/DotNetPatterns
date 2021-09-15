using System;
using System.Linq;

namespace DotNetPatterns.Maybe.Option
{
    public class Some<T> : Option<T>
    {
        public Some(T content)
            : base(content) { }

        public override T Do(Action<T> action)
        {
            contents.ToList().ForEach(x => action(x));
            return contents.FirstOrDefault();
        }

        public override IOption<T> When(Func<T, bool> func)
        {
            return contents.Any(func)
                ? new Some<T>(contents.FirstOrDefault(func))
                : new None<T>() as IOption<T>;
        }
    }


}
