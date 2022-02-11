using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class IronManObserver:INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine($"Iron Man received notification from {Name}");
        }
    }
}
