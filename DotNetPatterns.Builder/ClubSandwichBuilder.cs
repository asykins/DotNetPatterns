using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPatterns.Builder.Sandwiches;

namespace DotNetPatterns.Builder
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override ISandwichBuilder AddMainIngredient()
        {
            Sandwich.Cheese = "Emmental";
            Sandwich.Meat = "Ham";

            return this;
        }

        public override ISandwichBuilder AddToppings()
        {
            Sandwich.Toppings = new List<string>
            {
                "Tomatoes",
                "Salad",
                "Pickles"
            };

            return this;
        }

        public override ISandwichBuilder AddSauce()
        {
            Sandwich.Sauce = "Mayonaise";

            return this;
        }
    }
}
