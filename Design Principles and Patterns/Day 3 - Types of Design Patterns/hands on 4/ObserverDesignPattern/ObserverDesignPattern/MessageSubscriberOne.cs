using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class MessageSubscriberOne : Observer
    {
        public void Update(Message message)
        {
            Console.WriteLine("MessageSubscriberOne <=> " + message.getMessageContent());
        }
    }

    public class MessageSubscriberTwo : Observer
    {
        public void Update(Message message)
        {
            Console.WriteLine("MessageSubscriberTwo <=> " + message.getMessageContent());
        }
    }

    public class MessageSubscriberThree : Observer
    {
        public void Update(Message message)
        {
            Console.WriteLine("MessageSubscriberThree <=> " + message.getMessageContent());
        }
    }
}
