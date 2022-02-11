using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();

            IObserver Observer1 = new Observer("Happy New Year", 130);
            notificationService.AddSubscriber(Observer1);

            IObserver Observer2 = new Observer("Gudi Padwa", 50);
            notificationService.AddSubscriber(Observer2);

            IObserver Observer3 = new Observer("Diwali", 360);
            notificationService.AddSubscriber(Observer3);

            notificationService.RemoveSubscriber(Observer3);

            Console.ReadKey();
        }
    }
}
