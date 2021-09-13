using DotNetPatterns.Decorator.Robots;
using DotNetPatterns.Decorator.Robots.Decorators;
using System;
using System.Collections.Generic;

namespace DotNetPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new List<IRobot> { new Robot(), new RunningRobotDecorator(new FireFighterRobotDecorator(new Robot())) };
            robots.ForEach(robot =>
            {
                Console.WriteLine("new robot in line...");
                robot.Walk();
                robot.Fight();
            });
        }
    }
}
