using System;

namespace DotNetPatterns.State.Processes
{
    public abstract class Process : IProcess
    {
        protected IProcessState ProcessState { get; set; }

        public Process()
        {
            ProcessState = new Stopped();
        }

        public void Start()
        {
            ProcessState = ProcessState.Start(StartCallback);
        }

        public void Stop()
        {
            ProcessState = ProcessState.Stop(StopCallback);
        }

        protected abstract Action StartCallback { get; }
        protected abstract Action StopCallback { get; }
    }
}
