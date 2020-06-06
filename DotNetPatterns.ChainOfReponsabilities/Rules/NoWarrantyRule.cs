using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Rules
{
    public class NoWarrantyRule : IWarrantyRuleSet
    {
        public Action<Action> Claim => (action) => { };

        public void Damaged() { }

        public void Defective() { }

        public void Repaired() { }
    }
}
