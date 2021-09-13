using DotNetPatterns.Strategy.Strategies.Domain;
using DotNetPatterns.Strategy.Strategies.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Shipping = Countries.Belgium,
                Id = Guid.NewGuid(),
                Products = new List<Product>
                {
                    new Product
                    {
                        Description = "Product 1",
                        Name = "Product 1",
                        Price = 2.99
                    },
                    new Product
                    {
                        Description = "Product 2",
                        Name = "Product 2",
                        Price = 4.99
                    }

                }
            };

            Console.WriteLine("Before Taxes ...");
            Console.WriteLine($"Total Price : {order.Products.Sum(x => x.Price)}");
            Console.WriteLine("--------------------------------------------------------------");
            var strategyFactory = new StrategyFactory().Create(order.Shipping);
            strategyFactory.ComputeTaxes(order);

            Console.WriteLine("After Taxes ...");
            Console.WriteLine($"Total Price : {order.Products.Sum(x => x.Price)}");
        }
    }
}
