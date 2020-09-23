using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class NoCard : IATMState
    {
        ATMMachine atmMachine;

        public NoCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Enter card first");
        }

        public void InsertCard()
        {
            Console.WriteLine("Please enter a PIN");
            atmMachine.setATMState(atmMachine.YesCardState);
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("Please enter a pin");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter a card first");
        }
    }
}
