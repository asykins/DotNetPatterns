using DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class ExecutableTryCatchFinally<T, TResult> : IExecutable<T, TResult>
    {
        private readonly T _content;
        private readonly Func<T, TResult> _tryFunc;
        private readonly Dictionary<string, Action<T, Exception>> _catchActions;
        private readonly Action<T> _finallyAction;

        public ExecutableTryCatchFinally
            (T content, Func<T, TResult> tryFunc, Dictionary<string, Action<T, Exception>> catchActions, Action<T> finallyAction)
            => (_content, _tryFunc, _catchActions, _finallyAction) = (content, tryFunc, catchActions, finallyAction);
        
        public TResult Execute()
        {
            try
            {
                return _tryFunc(_content);
            }
            catch(Exception exception)
            {
                if (_catchActions == null || !_catchActions.Any(x => x.Key == exception.GetType().Name))
                    throw;
                else
                    _catchActions.First(x => x.Key == exception.GetType().Name).Value(_content, exception);

                return default;
            }
            finally
            {
                _finallyAction(_content);
            }
        }
    }
}
