using DotNetPatterns.Maybe.Option;
using System;

namespace DotNetPatterns.Maybe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("String does not contain 'some'");
            Console.WriteLine("----------------------");


            Option<string> option = "";

            option.When(x => x.Contains("some"))
                .Do(x => Console.WriteLine(x));

            option = "some";

            Console.WriteLine("----------------------");
            Console.WriteLine("String contains 'some'");
            Console.WriteLine("----------------------");

            option.When(x => x.Contains("some"))
                .Do(x => Console.WriteLine(x));

        }
    }
}