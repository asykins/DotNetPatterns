using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally
{
    public class ExecutableTryCatchFinally<T, TResult>
    {
        private readonly T _content;
        private readonly Func<T, TResult> _tryFunc;
        private readonly Func<T, Exception, TResult> _catchAction;
        private readonly Action<T> _finallyAction;

        public ExecutableTryCatchFinally
            (T content, Func<T, TResult> tryFunc, Func<T, Exception, TResult> catchAction, Action<T> finallyAction)
            => (_content, _tryFunc, _catchAction, _finallyAction) = (content, tryFunc, catchAction, finallyAction);
        
        public TResult Execute()
        {
            try
            {
                return _tryFunc(_content);
            }
            catch(Exception exception)
            {
                return _catchAction(_content, exception);
            }
            finally
            {
                _finallyAction(_content);
            }
        }
    }
}
