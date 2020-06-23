using DotNetPatterns.FluentTryCatchFinally.TryCatchFinally;
using System;

namespace DotNetPatterns.FluentTryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            string nullStr = "somestring";

            var newTryCatchResult = Trier<string, string>.Try(nullStr, x => throw new Exception())
                                        .Catch<ArgumentNullException>((x, exception) => Console.WriteLine("Bug"))
                                        .Catch<Exception>((x, exception) => Console.WriteLine("Super Bug !"))
                                        .Finally(x => Console.WriteLine("OK"))
                                        .Execute();

        }
    }
}
