using DotNetPatterns.Either.Either;
using System;

namespace DotNetPatterns.Either
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Response is OK");
            Handle(GetResponse(true));
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("Response not OK");
            Handle(GetResponse(false));
            Console.WriteLine("---------------");
        }

        static void Handle(Either<ArgumentNullException, string> response)
        {
            Console.WriteLine(
              response.Map(x => x.ToLower())
                .Reduce<string>(x => x.Message)
            );
        }

        static Either<ArgumentNullException, string> GetResponse(bool ok)
        {
            if (ok)
                return "Response";
            else
                return new ArgumentNullException("Params ok wasn't set to true");
        }
    }
}
