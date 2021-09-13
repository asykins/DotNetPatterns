using DotNetPatterns.Strategy.Strategies.Base;
using DotNetPatterns.Strategy.Strategies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Strategy.Strategies.Factories
{
    public class StrategyFactory
    {
        private readonly IReadOnlyDictionary<Countries, ITaxStrategy> strategies;

        public StrategyFactory() : this(DefaultStrategies.Create()) { }

        public StrategyFactory(IReadOnlyDictionary<Countries, ITaxStrategy> strategies)
        {
            this.strategies = strategies ?? throw new ArgumentNullException(nameof(strategies));
        }

        public ITaxStrategy Create(Countries country)
            => strategies.GetValueOrDefault(country);
    }
}
