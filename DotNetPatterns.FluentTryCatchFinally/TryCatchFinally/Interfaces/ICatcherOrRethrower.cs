using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces
{
    public interface ICatcherOrRethrower<T, TResult> : ICatcher<T, TResult>, IRethrower<T, TResult>
    {
        
    }
}
