using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.State.Processes
{
    public interface IProcessState
    {
        IProcessState Start(Action callback);

        IProcessState Stop(Action callback);
    }
}
