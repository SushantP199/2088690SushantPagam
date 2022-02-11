using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagePublisher messagePublisher = new MessagePublisher();

            MessageSubscriberOne messageSubscriberOne = new MessageSubscriberOne();
            messagePublisher.Attach(messageSubscriberOne);

            MessageSubscriberTwo messageSubscriberTwo = new MessageSubscriberTwo();
            messagePublisher.Attach(messageSubscriberTwo);

            MessageSubscriberThree messageSubscriberThree = new MessageSubscriberThree();
            messagePublisher.Attach(messageSubscriberThree);

            messagePublisher.ChangeState(2);

            Console.ReadLine();
        }
    }
}

