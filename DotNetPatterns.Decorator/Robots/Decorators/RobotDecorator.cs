using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Decorator.Robots.Decorators
{
    public abstract class RobotDecorator : IRobot
    {
        protected readonly IRobot robot;

        public RobotDecorator(IRobot robot)
        {
            this.robot = robot ?? throw new ArgumentNullException(nameof(robot));
        }
        public virtual void Fight()
        {
            robot.Fight();
        }

        public virtual void Walk()
        {
            robot.Walk();
        }
    }
}
