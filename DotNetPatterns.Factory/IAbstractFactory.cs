using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory
{
    public interface IAbstractFactory<TKey, TResult>
    {
        TResult Create(TKey key, params object[] constructorParams);
    }
}
