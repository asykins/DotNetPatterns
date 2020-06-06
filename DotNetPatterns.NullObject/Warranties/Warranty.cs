using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.NullObject.Warranties
{
    public abstract class Warranty : IWarranty
    {
        public abstract void Claim();
    }
}
