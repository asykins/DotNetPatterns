using DotNetPatterns.Strategy.Strategies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Strategy.Strategies.Base
{
    public interface ITaxStrategy
    {
        void ComputeTaxes(Order order);
    }
}
