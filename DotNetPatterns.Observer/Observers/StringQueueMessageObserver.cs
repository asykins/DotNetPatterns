using DotNetPatterns.Observer.Subject.Models;
using System;

namespace DotNetPatterns.Observer.Observers
{
    public class StringQueueMessageObserver : Observer<Message>
    {
        public override void OnNext(Message value)
        {
            if (value?.Type != "String")
                return;
            else
                Console.WriteLine($"String Message : -- {value.Content}");

        }
    }
}
