using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Builder.Sandwiches
{
    public class Sandwich : ISandwich
    {
        public string Chicken { get; set; }
        public string Fish { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }

        public List<string> Toppings { get; set; }
    }
}
