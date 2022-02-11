using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class DoctorStrangeObserver : INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine($"Doctor Strange received notification from {Name}");
        }
    }
}