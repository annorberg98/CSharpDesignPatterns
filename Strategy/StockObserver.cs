using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class StockObserver : IObserver
    {
        private double ibmPrice, aaplPrice, googPrice;

        private static int observerIDTracker = 0;

        private int observerID;

        private ISubject stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            this.observerID = ++observerIDTracker;

            Console.WriteLine("New Observer: " + this.observerID);

            stockGrabber.Register(this);

        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;

            PrintPrices();
        }

        public void PrintPrices()
        {
            Console.WriteLine(observerID + "\nIBM: " + ibmPrice
                + "\nAAPL: " + aaplPrice
                + "\nGOOG: " + googPrice
                + "\n"
                );
        }
    }
}
