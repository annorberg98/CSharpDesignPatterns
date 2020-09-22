using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface ISubject
    {
        public void Register(IObserver o);
        public void Unregister(IObserver o);

        public void NotifyObserver();
    }
}
