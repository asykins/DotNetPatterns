using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Builder.Sandwiches
{
    public interface ISandwich
    {
        string Chicken { get; set; }
        string Fish { get; set; }
        string Meat { get; set; }
        string Cheese { get; set; }
        string Sauce { get; set; }

        List<string> Toppings { get; set; }
    }
}
