using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Decorator.Robots
{
    public class Robot : IRobot
    {
        public void Walk()
        {
            Console.WriteLine("Walk");
        }

        public void Fight()
        {
            Console.WriteLine("Fight !");
        }
    }
}
