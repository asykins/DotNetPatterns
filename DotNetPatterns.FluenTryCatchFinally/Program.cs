using DotNetPatterns.FluentTryCatchFinally.TryCatchFinally;
using System;

namespace DotNetPatterns.FluentTryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "someString";

            var result = Trier<string, string>.Try(str, x => x.Replace('s', 'S'))
                            .Catch((x, exception) => {
                                Console.WriteLine($"An error occured while processing {str} : {exception}");
                                return str;
                            })
                            .Finally(x => Console.WriteLine("Cleaning up..."))
                            .Execute();

            Console.WriteLine(result);

            Console.WriteLine("\n-----------------------------------------------------------------------------\n");

            string nullStr = null;

            var nullResult = Trier<string, string>.Try(nullStr, x => x.Replace('s', 'S'))
                            .Catch((x, exception) => {
                                Console.WriteLine($"An error occured while processing {str} : {exception}");
                                return nullStr;
                            })
                            .Finally(x => Console.WriteLine("Cleaning up..."))
                            .Execute();

            Console.WriteLine(nullResult ?? "Value is null");
        }
    }
}
