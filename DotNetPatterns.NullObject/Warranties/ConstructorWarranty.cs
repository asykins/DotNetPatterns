using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.NullObject.Warranties
{
    public class ConstructorWarranty : Warranty
    {
        public override void Claim()
        {
            Console.WriteLine("Claiming Constructor Warranty");
        }
    }
}
