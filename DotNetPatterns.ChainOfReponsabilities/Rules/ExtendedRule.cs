using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Rules
{
    public class ExtendedRule : WarrantyRuleSet
    {
        private readonly Action<Action> _claimAction;

        public ExtendedRule(Action<Action> claimAction, IWarrantyRuleSet nextHandler)
            : base(nextHandler) => (_claimAction) = (claimAction);

        protected override void HandleDamagedProduct()
        {
            base.Claim = _claimAction;
        }

        protected override void HandleRepairedProduct()
        {
            base.Claim = base.Forward;
        }
    }
}
