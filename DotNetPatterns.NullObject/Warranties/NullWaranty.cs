using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.NullObject.Warranties
{
    public class NullWaranty : Warranty
    {
        [ThreadStatic]
        private static IWarranty _instance;

        public static IWarranty Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NullWaranty();
                return _instance;
            }
        }

        public override void Claim() { }
    }
}
