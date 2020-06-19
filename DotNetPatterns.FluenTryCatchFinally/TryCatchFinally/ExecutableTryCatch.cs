using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class ExecutableTryCatch<T, TResult>
    {
        private readonly T _content;
        private readonly Func<T, TResult> _tryFunc;
        private readonly Func<T, Exception, TResult> _catchAction;

        public ExecutableTryCatch
            (T content, Func<T, TResult> tryFunc, Func<T, Exception, TResult> catchAction)
            => (_content, _tryFunc, _catchAction) = (content, tryFunc, catchAction);

        public ExecutableTryCatchFinally<T, TResult> Finally(Action<T> finallyAction)
            => new ExecutableTryCatchFinally<T, TResult>
                (_content, _tryFunc, _catchAction, finallyAction);

        public TResult Execute()
            => new ExecutableTryCatchFinally<T, TResult>
                (_content, _tryFunc, _catchAction, (T content) => { })
                    .Execute();

    }
}
