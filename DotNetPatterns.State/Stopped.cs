using DotNetPatterns.State.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.State
{
    public class Stopped : IProcessState
    {
        public IProcessState Start(Action callback)
        {
            callback();
            return new Started();
        }

        public IProcessState Stop(Action callback) => this;
    }
}
