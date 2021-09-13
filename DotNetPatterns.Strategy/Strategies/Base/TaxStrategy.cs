using DotNetPatterns.Strategy.Strategies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Strategy.Strategies.Base
{
    public class TaxStrategy : ITaxStrategy
    {
        protected virtual double Tax { get; } = 1;

        public virtual void ComputeTaxes(Order order)
        {
            if (order?.Products?.Any() ?? false)
                order.Products.ForEach(x => x.Price *= Tax);
        }
    }
}
