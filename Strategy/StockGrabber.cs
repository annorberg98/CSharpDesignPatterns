using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> observers;
        private double ibmPrice, aaplPrice, googPrice;

        public StockGrabber()
        {
            observers = new List<IObserver>();
        }

        public void Register(IObserver o)
        {
            observers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            int observerIndex = observers.IndexOf(o);
            Console.WriteLine("Observer " + ++observerIndex + " deleted");

            observers.RemoveAt(observerIndex);
        }

        public void NotifyObserver()
        {
           foreach(IObserver o in observers)
            {
                o.Update(ibmPrice, aaplPrice, googPrice);
            }
        }

        public void setIBMPrice(double newIbmPrice)
        {
            this.ibmPrice = newIbmPrice;
            NotifyObserver();
        }

        public void setAAPLPrice(double newAaplPrice)
        {
            this.aaplPrice = newAaplPrice;
            NotifyObserver();
        }

        public void setGOOGPrice(double newGoogPrice)
        {
            this.googPrice = newGoogPrice;
            NotifyObserver();
        }
    }
}
