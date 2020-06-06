using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Warranties
{
    public interface IWarranty
    {
        void Claim(Action onValidClaim);
    }
}
