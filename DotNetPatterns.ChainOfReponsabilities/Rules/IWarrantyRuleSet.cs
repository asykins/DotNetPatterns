using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Rules
{
    public interface IWarrantyRuleSet
    {
        void Repaired();
        void Damaged();
        void Defective();
        Action<Action> Claim { get; }
    }
}
