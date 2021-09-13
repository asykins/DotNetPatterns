using System;

namespace DotNetPatterns.Decorator.Robots.Decorators
{
    public class FireFighterRobotDecorator : RobotDecorator
    {
        public FireFighterRobotDecorator(IRobot robot)
            : base(robot) { }

        public override void Fight()
        {
            Console.WriteLine("Pull water lance...");
            robot.Fight();
            Console.WriteLine("Put water lance back...");
        }
    }
}
