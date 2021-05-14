using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Observer.Observers
{
    public abstract class Observer<T> : IObserver<T>
    {
        protected IDisposable Unsubscriber { get; set; }

        public virtual void OnCompleted()
        {
        }

        public virtual void OnError(Exception error)
        {
            throw error;
        }

        public virtual void OnNext(T value)
        {
        }

        public virtual void Subscribe(IObservable<T> subject)
        {
            Unsubscriber = subject.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            Unsubscriber.Dispose();
        }
    }
}
