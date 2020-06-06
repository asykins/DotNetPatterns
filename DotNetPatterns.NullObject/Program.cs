using DotNetPatterns.NullObject.Warranties;
using System;

namespace DotNetPatterns.NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullyWarrantedProduct = new SoldedProduct(new ConstructorWarranty(), new ExtendedWarranty());
            var constructorWarrantedProduct = new SoldedProduct(new ConstructorWarranty(), null);
            var notWarrantedProduct = new SoldedProduct(null, null);

            Console.WriteLine("Fully Warranted Product");
            fullyWarrantedProduct.ClaimConstructorWarranty();
            fullyWarrantedProduct.ClaimExtendedWarranty();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Constructor Warranted Product");
            constructorWarrantedProduct.ClaimConstructorWarranty();
            constructorWarrantedProduct.ClaimExtendedWarranty();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Not Warranted Product");
            notWarrantedProduct.ClaimConstructorWarranty();
            notWarrantedProduct.ClaimExtendedWarranty();
        }
    }
}
