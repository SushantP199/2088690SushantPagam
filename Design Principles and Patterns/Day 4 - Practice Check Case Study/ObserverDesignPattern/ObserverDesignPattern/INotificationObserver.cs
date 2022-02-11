using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    interface INotificationObserver
    {
        string Name { get; set; }

        void OnServerDown();
    }
}
