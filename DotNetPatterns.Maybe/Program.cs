using DotNetPatterns.Maybe.MaybeStructure;
using System;

namespace DotNetPatterns.Maybe
{
    class Program
    {
        static void Main(string[] args)
        {
            Maybe<string> maybe = "someString";
            maybe.Do(content => Console.WriteLine(content));
            
            string str = null;
            Maybe<string> maybeNull = str;
            maybeNull.Do(content => Console.WriteLine($"No gonna happen : {content}"));
        }
    }
}