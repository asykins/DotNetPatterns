using DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class ExecutableTryCatch<T, TResult> : IExecutableCatcher<T, TResult>, IExecutableRethrower<T, TResult>
    {
        private readonly T _content;
        private readonly Func<T, TResult> _tryFunc;
        private Dictionary<string, Action<T, Exception>> _catchActions;

        public ExecutableTryCatch
            (T content, Func<T, TResult> tryFunc, Dictionary<string, Action<T, Exception>> catchActions)
            => (_content, _tryFunc, _catchActions) = (content, tryFunc, catchActions);

        public IExecutable<T, TResult> Finally(Action<T> finallyAction)
            => new ExecutableTryCatchFinally<T, TResult>
                (_content, _tryFunc, _catchActions, finallyAction);

        public TResult Execute()
            => new ExecutableTryCatchFinally<T, TResult>
                (_content, _tryFunc, _catchActions, (T content) => { })
                    .Execute();

        public IExecutableCatcher<T, TResult> Catch<ExceptionType>(Action<T, Exception> catchAction)
        {
            _catchActions.Add(typeof(Exception).Name, catchAction);
            return this;
        }
    }
}
