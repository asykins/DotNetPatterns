using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.State.Processes
{
    public interface IProcess
    {
        void Start();

        void Stop();
    }
}
