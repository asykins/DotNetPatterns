using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces
{
    public interface ICatcher<T, TResult>
    {
        IExecutableCatcher<T, TResult> Catch<ExceptionType>(Action<T, Exception> catchAction);
    }
}
