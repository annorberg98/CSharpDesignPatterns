using System;
using CommandPattern;
using ObserverPattern;
using StatePattern;
using StrategyPattern;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunObserver();


            Console.ReadLine();
        }

        public static void RunStrategy()
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine("Dog: " + sparky.TryToFly());
            Console.WriteLine("Bird: " + tweety.TryToFly());

            sparky.FlyingType = new ItFlys();

            Console.WriteLine("Dog: " + sparky.TryToFly());
        }

        public static void RunState()
        {
            ATMMachine atm = new ATMMachine();
            atm.insertCard();
            atm.ejectCard();
            atm.insertCard();
            atm.insertPin(1234);
            atm.requestCash(2000);
            atm.insertCard();
            atm.insertPin(1234);
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
