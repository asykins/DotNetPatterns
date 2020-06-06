using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Warranties
{
    public class WarrantyExpired : IWarranty
    {
        [ThreadStatic]
        private static IWarranty _instance;

        public static IWarranty Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WarrantyExpired();
                return _instance;
            }
        }

        private WarrantyExpired() { }

        public void Claim(Action onValidClaim) { }
    }
}
