using DotNetPatterns.Observer.Subject.Models;
using System;

namespace DotNetPatterns.Observer.Observers
{
    public class BinaryQueueMessageObserver : Observer<Message>
    {
        public override void OnNext(Message value)
        {
            if (value?.Type != "Binary")
                return;
            else
                Console.WriteLine($"Binary Message : -- {value.Content}");

        }
    }
}
