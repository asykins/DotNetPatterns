using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.FluentTryCatchFinally.TryCatchFinally.Interfaces
{
    public interface IRethrower<T, TResult>
    {
        IExecutableRethrower<T, TResult> ReThrow();
    }
}
