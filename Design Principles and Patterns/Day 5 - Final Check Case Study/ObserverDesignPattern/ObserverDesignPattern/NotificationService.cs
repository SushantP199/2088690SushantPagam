using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class NotificationService : IService
    {
        List<IObserver> notificationObserverList = new List<IObserver>();

        public void NotifySubscriber()
        {
            foreach (var list in notificationObserverList)
            {
                list.Notify();
            }
        }

        public void AddSubscriber(IObserver notificationObserver)
        {
            if (notificationObserver.Ticket >= 100)
            {
                notificationObserverList.Add(notificationObserver);
                Console.WriteLine("\nList of Events Subscribed");
                foreach (var list in notificationObserverList)
                {
                    Console.WriteLine(list.EventName);
                }
                NotifySubscriber();
            }
        }

        public void RemoveSubscriber(IObserver notificationObserver)
        {
            notificationObserverList.Remove(notificationObserver);
            Console.WriteLine("\nList of Events Subscribed");
            foreach (var list in notificationObserverList)
            {
                Console.WriteLine(list.EventName);
            }
        }
    }
}
