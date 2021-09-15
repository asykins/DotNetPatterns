using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Maybe.Option
{
    public class None<T> : Option<T>
    {
        public None()
            : base(default) { }

        public override T Do(Action<T> action)
            => default;

        public override IOption<T> When(Func<T, bool> func)
            => new None<T>();
    }
}
