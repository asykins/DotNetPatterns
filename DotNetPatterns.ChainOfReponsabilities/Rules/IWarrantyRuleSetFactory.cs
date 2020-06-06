using DotNetPatterns.ChainOfReponsabilities.Warranties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Rules
{
    public interface IWarrantyRuleSetFactory
    {
        IWarrantyRuleSet Create(Action<Action> claimConstructorWarranty, 
                                Action<Action> claimExtendedWarranty);
    }
}
