using DotNetPatterns.Observer.Observers;
using DotNetPatterns.Observer.Subject;
using DotNetPatterns.Observer.Subject.Models;
using System;

namespace DotNetPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new RemoteQueueHandler();
            var stringObserver = new StringQueueMessageObserver();
            var binaryObserver = new BinaryQueueMessageObserver();

            stringObserver.Subscribe(subject);
            binaryObserver.Subscribe(subject);

            var stringMessage = new Message { Content = "This is a string !", Type = "String", Id = Guid.NewGuid() };
            var binaryMessage = new Message { Content = "001010001111101010101011101010010111", Type = "Binary", Id = Guid.NewGuid() };

            Console.WriteLine($"-- Sending String Message");
            subject.Notify(stringMessage);
            Console.WriteLine($"-- Sending String Message");
            subject.Notify(stringMessage);
            stringObserver.Unsubscribe();
            Console.WriteLine($"-- Sending String & Binary Message");
            subject.Notify(binaryMessage, stringMessage);
            Console.WriteLine($"-- Sending Two Binary Message");
            subject.Notify(binaryMessage, binaryMessage);
            binaryObserver.Unsubscribe();
            subject.Notify(binaryMessage, binaryMessage);
            Console.WriteLine($"-- Sending Two Binary Message");

        }
    }
}
