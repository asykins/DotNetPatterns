using System;

namespace DotNetPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo with a "Fluent Builder Pattern"
            //Can also be done with a Director which orchestrate the creation of the object

            ISandwichBuilder sandwichBuilder = new ClubSandwichBuilder();

            var clubSandwich = sandwichBuilder.AddSauce()
                                                .AddMainIngredient()
                                                .AddToppings()
                                                .GetSandwich();

            Console.WriteLine("Here is the created sandwich");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Main Ingredient : {clubSandwich.Meat} and {clubSandwich.Cheese}\n");
            Console.WriteLine($"Toppings : \n");
            clubSandwich.Toppings.ForEach(topping => Console.WriteLine($"     {topping}\n"));
            Console.WriteLine($"Sauce : {clubSandwich.Sauce}");

        }
    }
}
