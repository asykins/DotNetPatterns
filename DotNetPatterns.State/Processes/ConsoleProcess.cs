using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.State.Processes
{
    public class ConsoleProcess : Process
    {
        protected override Action StartCallback => () =>
        {
            Console.WriteLine("Process Started\n");
            Console.WriteLine("Starting hard work...\n");
            Console.WriteLine("Starting really hard work...\n");
            Console.WriteLine("Starting reaaaaallllly hard work...\n");
        };

        protected override Action StopCallback => () =>
        {
            Console.WriteLine("Stopping reaaaaallllly hard work...\n");
            Console.WriteLine("Stopping really hard work...\n");
            Console.WriteLine("Stopping hard work...\n");
            Console.WriteLine("Cleaning up resources...\n");
            Console.WriteLine("Process Stopped");
        };
    }
}
