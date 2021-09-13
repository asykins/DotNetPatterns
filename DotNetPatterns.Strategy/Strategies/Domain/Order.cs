using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Strategy.Strategies.Domain
{
    public class Order
    { 
        public Guid Id { get; set; }
        public Countries Shipping { get; set; }
        public List<Product> Products { get; set; }
    }
}
