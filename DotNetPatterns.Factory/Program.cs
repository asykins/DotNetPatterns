using DotNetPatterns.Factory.Reports;
using System;

namespace DotNetPatterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = (IReportFactory)UnityConfig.Container.Resolve(typeof(IReportFactory), null, null);

            Console.WriteLine(factory.Create(ReportType.Monthly, DateTime.Now));
            Console.WriteLine("\n");
            Console.WriteLine(factory.Create(ReportType.Weekly, DateTime.Now));
        }
    }
}
