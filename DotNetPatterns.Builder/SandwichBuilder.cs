using DotNetPatterns.Builder.Sandwiches;

namespace DotNetPatterns.Builder
{
    public abstract class SandwichBuilder : ISandwichBuilder
    {
        protected ISandwich Sandwich;

        public SandwichBuilder()
        {
            Reset();
        }

        public SandwichBuilder Reset() 
        { 
            Sandwich = new Sandwich(); 
            return this; 
        }

        public ISandwich GetSandwich() => Sandwich;

        public abstract ISandwichBuilder AddMainIngredient();
        public abstract ISandwichBuilder AddToppings();
        public abstract ISandwichBuilder AddSauce();
    }
}
