using DotNetPatterns.Maybe.MaybeStructure;
using System;

namespace DotNetPatterns.Maybe
{
    class Program
    {
        static void Main(string[] args)
        {
            Maybe<string> maybe = Maybe<string>.Some("SomeString");
            maybe.Do(str => Console.WriteLine(str));
            maybe = Maybe<string>.None();
            maybe.Do(str => Console.WriteLine($"No gonna happen : {str}"));
        }
    }
}
