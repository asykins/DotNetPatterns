using DotNetPatterns.State.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.State
{
    public class Started : IProcessState
    {
        public IProcessState Start(Action callback) => this;

        public IProcessState Stop(Action callback) 
        {
            callback();
            return new Stopped();
        }
    }
}
