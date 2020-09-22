using System;
using CommandPattern;
using ObserverPattern;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCommand();

            Console.ReadLine();
        }

        public static void RunCommand()
        {
            IElectronicDevice newDevice = TVRemote.getDevice();

            TurnTVOn onCommand = new TurnTVOn(newDevice);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.Press();

            // -------

            TurnTVOff offCommand = new TurnTVOff(newDevice);

            onPressed = new DeviceButton(offCommand);

            onPressed.Press();

            // -------

            TurnTVUp upCommand = new TurnTVUp(newDevice);

            onPressed = new DeviceButton(upCommand);

            onPressed.Press();
        }

        public static void RunObserver()
        {
            StockGrabber grabber = new StockGrabber();

            StockObserver o1 = new StockObserver(grabber);

            grabber.setIBMPrice(197);
            grabber.setAAPLPrice(667);
            grabber.setGOOGPrice(676);

            StockObserver o2 = new StockObserver(grabber);

            grabber.setIBMPrice(197);
            grabber.setAAPLPrice(667);
            grabber.setGOOGPrice(676);

            grabber.Unregister(o1);
        }
    }
}
