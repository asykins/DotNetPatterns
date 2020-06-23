using DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class InitialCatcher<T, TResult> : ICatcherOrRethrower<T, TResult>
    {
        private readonly T _content;
        private readonly Func<T, TResult> _tryFunc;

        private Dictionary<string, Action<T, Exception>> _catchActions;

        public InitialCatcher(T content, Func<T, TResult> tryFunc)
            => (_content, _tryFunc, _catchActions) = (content, tryFunc, new Dictionary<string, Action<T, Exception>>());

        public IExecutableCatcher<T, TResult> Catch<ExceptionType>(Action<T, Exception> catchAction)
        {
            _catchActions.Add(typeof(ExceptionType).Name, catchAction);
            return new ExecutableTryCatch<T, TResult>(this._content, this._tryFunc, this._catchActions);
        }

        public IExecutableRethrower<T, TResult> ReThrow()
            => new ExecutableTryCatch<T, TResult>(this._content, this._tryFunc, this._catchActions);
    }
}
