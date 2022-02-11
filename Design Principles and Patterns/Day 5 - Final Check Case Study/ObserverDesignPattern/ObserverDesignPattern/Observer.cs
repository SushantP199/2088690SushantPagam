using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class Observer:IObserver
    {
        public string EventName { get; set; }
        public int Ticket { get; set; }

        public Observer(string eventName, int ticket)
        {
            if (ticket >= 100)
            {
                this.Ticket = ticket;
                EventName = eventName;
            }
        }

        public void Notify()
        {
            Console.WriteLine($"Admin recived notification from {EventName} event with {Ticket} tickets");
        }
    }
}
