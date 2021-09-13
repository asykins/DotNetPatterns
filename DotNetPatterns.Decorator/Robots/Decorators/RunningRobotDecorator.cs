using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Decorator.Robots.Decorators
{
    public class RunningRobotDecorator : RobotDecorator
    {
        public RunningRobotDecorator(IRobot robot)
            : base(robot) { }

        public override void Walk()
        {
            Console.WriteLine("Running !!!");
        }
    }
}
