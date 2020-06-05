using DotNetPatterns.Builder.Sandwiches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Builder
{
    public interface ISandwichBuilder
    {
        ISandwichBuilder AddToppings();
        ISandwichBuilder AddSauce();
        ISandwichBuilder AddMainIngredient();

        ISandwich GetSandwich();
    }
}
