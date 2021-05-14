using DotNetPatterns.Observer.Observers;
using DotNetPatterns.Observer.Subject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetPatterns.Observer.Subject
{
    public class RemoteQueueHandler : IObservable<Message>
    {
        public List<IObserver<Message>> Observers { get; set; }

        public RemoteQueueHandler()
        {
            Observers = new List<IObserver<Message>>();
        }

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            if(!Observers?.Any() ?? true)
            {
                Observers = new List<IObserver<Message>>();
            }

            if(!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }

            return new Unsubscriber<Message>(Observers, observer);
        }

        public void Notify(params Message[] messages)
        {
            if (!messages?.Any() ?? true)
                return;

            foreach(var message in messages)
            {
                Observers.ForEach(x => x.OnNext(message));
            }
        }
    }
}
