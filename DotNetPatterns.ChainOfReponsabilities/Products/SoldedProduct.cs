using DotNetPatterns.ChainOfReponsabilities.Rules;
using DotNetPatterns.ChainOfReponsabilities.Warranties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Products
{
    public class SoldedProduct
    {
        private readonly IWarranty _constructorWarranty;
        private readonly IWarranty _extendedWarranty;

        private readonly IWarrantyRuleSet _warrantyRuleSet;

        public SoldedProduct(IWarranty constructorWarranty, IWarranty extendedWarranty,
                             IWarrantyRuleSetFactory warrantyRuleSetFactory)
        {
            _constructorWarranty = constructorWarranty 
                ?? throw new ArgumentNullException(nameof(constructorWarranty));

            _extendedWarranty = extendedWarranty ?? WarrantyExpired.Instance;

            _ = warrantyRuleSetFactory 
                ?? throw new ArgumentNullException(nameof(warrantyRuleSetFactory));

            _warrantyRuleSet = warrantyRuleSetFactory.Create
                (ClaimConstructorWarranty, ClaimExtendedWarranty);
        }

        private void ClaimConstructorWarranty(Action onValidClaim)
            => _constructorWarranty.Claim(onValidClaim);

        private void ClaimExtendedWarranty(Action onValidClaim)
            => _extendedWarranty.Claim(onValidClaim);

        public void MarkAsDefective() => _warrantyRuleSet.Defective();

        public void MarkedAsDamaged() => _warrantyRuleSet.Damaged();

        public void MarkedAsRepaired() => _warrantyRuleSet.Repaired();

        public void ClaimWarranty(Action onValidClaim) => _warrantyRuleSet.Claim(onValidClaim);
    }
}
