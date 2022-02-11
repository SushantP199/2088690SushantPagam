using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    interface IObserver
    {
        int Ticket { get; set; }

        string EventName { get; set; }

        void Notify();
    }
}
