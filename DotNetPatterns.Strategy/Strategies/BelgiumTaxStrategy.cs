using DotNetPatterns.Strategy.Strategies.Base;
using DotNetPatterns.Strategy.Strategies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Strategy.Strategies
{
    public class BelgiumTaxStrategy : TaxStrategy
    {
        protected override double Tax => 1.21;
    }
}
