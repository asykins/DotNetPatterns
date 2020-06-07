using DotNetPatterns.Maybe.MaybeStructure;
using System;

namespace DotNetPatterns.Maybe
{
    class Program
    {
        static void Main(string[] args)
        {
            Maybe<string> str = "someString";

            str = str.WhenSome(x => Console.WriteLine(x))
                     .WhenNone(() => Console.WriteLine("Nothing in there"));

            str = Maybe<string>.None();

            str = str.WhenSome(x => Console.WriteLine(x))
                     .WhenNone(() => Console.WriteLine("Nothing in there"));

        }
    }
}