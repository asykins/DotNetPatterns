using DotNetPatterns.ChainOfReponsabilities.Products;
using DotNetPatterns.ChainOfReponsabilities.Rules;
using DotNetPatterns.ChainOfReponsabilities.Warranties;
using System;

namespace DotNetPatterns.ChainOfReponsabilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var consValidUntil = DateTime.Now.AddYears(-1);
            var extendedValidUntil = DateTime.Now.AddYears(1);

            var soldedProduct = new SoldedProduct
                (new Warranty(consValidUntil), new Warranty(extendedValidUntil),
                 new DefaultRuleSet());

            //Constructor warranty should be claimed on defective product if not expired
            soldedProduct.MarkAsDefective();

            soldedProduct.ClaimWarranty(() => Console.WriteLine("Constructor Claimed !"));

            //Making the product repaired
            soldedProduct.MarkedAsRepaired();

            //Some times later

            //Extended warranty should be claimed on damaged product if not expired
            soldedProduct.MarkedAsDamaged();

            soldedProduct.ClaimWarranty(() => Console.WriteLine("Extended Claimed !"));

            //Output
            //Extended Claimed !
        }
    }
}
