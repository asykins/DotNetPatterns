using DotNetPatterns.Strategy.Strategies.Base;
using DotNetPatterns.Strategy.Strategies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Strategy.Strategies.Factories
{
    public class DefaultStrategies
    {
        public static IReadOnlyDictionary<Countries, ITaxStrategy> Create()
            => new Dictionary<Countries, ITaxStrategy>() { 
                { Countries.Belgium, new BelgiumTaxStrategy() },
                { Countries.Free, new TaxFreeStrategy() } 
            };
    }
}
