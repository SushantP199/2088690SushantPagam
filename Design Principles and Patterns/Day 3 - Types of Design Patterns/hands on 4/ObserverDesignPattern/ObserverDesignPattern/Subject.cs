using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public interface Subject
    {
        int GetState { get; set; }

        void ChangeState(int val);

        void Attach(Observer o);

        void Detach(Observer o);
    }
}
