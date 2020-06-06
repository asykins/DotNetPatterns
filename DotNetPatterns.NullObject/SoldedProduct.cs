using DotNetPatterns.NullObject.Warranties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.NullObject
{
    public class SoldedProduct
    {
        private IWarranty _constructorWarranty;
        private IWarranty _extendedWarranty;

        public SoldedProduct(IWarranty constructorWarranty, IWarranty extendedWarranty)
        {
            _constructorWarranty = constructorWarranty ?? NullWaranty.Instance;
            _extendedWarranty = extendedWarranty ?? NullWaranty.Instance;
        }

        public void ClaimConstructorWarranty()
            => _constructorWarranty.Claim();

        public void ClaimExtendedWarranty()
            => _extendedWarranty.Claim();
    }
}
