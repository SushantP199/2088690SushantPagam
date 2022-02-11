using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class MessagePublisher : Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int getState = 1;
        public int GetState { get => getState; set => value = getState; }

        public void Attach(Observer observer)
        {
            observers.Add(observer);

        }

        public void ChangeState(int val)
        {
            if (val != getState)
            {

                GetState = val;

                NotifyUpdate(new Message("Subject State has been changed"));
            }
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void NotifyUpdate(Message message)
        {
            observers.ForEach(n => n.Update(message));
        }
    }
}
