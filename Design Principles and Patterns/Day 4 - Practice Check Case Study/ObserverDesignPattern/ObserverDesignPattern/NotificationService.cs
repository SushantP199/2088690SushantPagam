using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class NotificationService:INotificationService
    {
        List<INotificationObserver> notificationObserverList = new List<INotificationObserver>();

        int count = 1;

        public void NotifySubscriber()
        {
            foreach (var list in notificationObserverList)
            {
                list.OnServerDown();
            }
        }

        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            notificationObserverList.Add(notificationObserver);

            Console.WriteLine();
            Console.WriteLine($"List of Subscribers No.{count}");

            count++;
            foreach (var list in notificationObserverList)
            {
                Console.WriteLine($"{list.Name}");
            }
            NotifySubscriber();
        }

        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            notificationObserverList.Remove(notificationObserver);

            Console.WriteLine("\nList of Subscribers are as follows");
            foreach (var list in notificationObserverList)
            {
                Console.WriteLine(list.Name);
            }
        }
    }
}