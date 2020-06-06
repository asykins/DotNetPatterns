using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Rules
{
    public class WarrantyRuleSet : IWarrantyRuleSet
    {
        private readonly IWarrantyRuleSet _nextHandler;

        protected void Forward(Action onValidClaim) => _nextHandler.Claim(onValidClaim);

        public Action<Action> Claim { get; protected set; }

        public WarrantyRuleSet(IWarrantyRuleSet nextHandler)
            => (_nextHandler, Claim) = (nextHandler, Forward);


        public void Damaged() 
        {
            HandleDamagedProduct();
            _nextHandler.Damaged();
        }

        public  void Defective()
        {
            HandleDefectiveProduct();
            _nextHandler.Defective();
        }

        public virtual void Repaired() 
        {
            HandleRepairedProduct();
            _nextHandler.Repaired();
        }

        protected virtual void HandleDamagedProduct() { }

        protected virtual void HandleDefectiveProduct() { }

        protected virtual void HandleRepairedProduct() { }
    }
}
