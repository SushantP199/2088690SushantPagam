using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();

            INotificationObserver ironManObserver = new IronManObserver();
            ironManObserver.Name = "Sushant";
            notificationService.AddSubscriber(ironManObserver);

            INotificationObserver doctorStrangeObserver = new DoctorStrangeObserver();
            doctorStrangeObserver.Name = "Sujay";
            notificationService.AddSubscriber(doctorStrangeObserver);

            notificationService.RemoveSubscriber(ironManObserver);

            Console.ReadKey();
        }
    }
}
