using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class Catcher<T, TResult>
    {
        private readonly T _content;
        private readonly Func<T, TResult> _tryFunc;

        public Catcher(T content, Func<T, TResult> tryFunc)
            => (_content, _tryFunc) = (content, tryFunc);

        public ExecutableTryCatch<T, TResult> Catch(Func<T, Exception, TResult> catchAction)
            => new ExecutableTryCatch<T, TResult>(_content, _tryFunc, catchAction);
    }
}
