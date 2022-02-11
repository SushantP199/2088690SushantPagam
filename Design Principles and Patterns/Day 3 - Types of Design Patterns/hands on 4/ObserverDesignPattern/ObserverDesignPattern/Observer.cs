using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public interface Observer
    {
        void Update(Message m);
    }
}
