using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPatterns.ChainOfReponsabilities.Warranties;

namespace DotNetPatterns.ChainOfReponsabilities.Rules
{
    public class DefaultRuleSet : IWarrantyRuleSetFactory
    {
        public IWarrantyRuleSet Create(Action<Action> claimConstructorWarranty, Action<Action> claimExtendedWarranty)
            => new ConstructorRule(claimConstructorWarranty,
                    new ExtendedRule(claimExtendedWarranty,
                        new NoWarrantyRule()));
    }
}
