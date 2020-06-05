using DotNetPatterns.State.Processes;
using System;

namespace DotNetPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcess consoleProcess = new ConsoleProcess();
            //Starting a new process
            consoleProcess.Start();

            //Trying to start a already started process
            consoleProcess.Start();
            
            //Stopping the process
            consoleProcess.Stop();
        }
    }
}
