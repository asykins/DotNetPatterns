using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory
{
    public abstract class AbstractFactory<TKey, TResult> : IAbstractFactory<TKey, TResult>
        where TResult : class
    {
        public Dictionary<TKey, Type> container;

        public AbstractFactory()
        {
            container = new Dictionary<TKey, Type>();
        }

        public TResult Create(TKey key, params object[] constructorParams)
            => (TResult)Activator.CreateInstance
                (container.First(x => x.Key.Equals(key)).Value, constructorParams);
    }
}
