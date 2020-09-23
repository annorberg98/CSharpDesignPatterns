using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class HasCard : IATMState
    {

        ATMMachine atmMachine;

        public HasCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            atmMachine.setATMState(atmMachine.NoCardState);
        }

        public void InsertCard()
        {
            Console.WriteLine("You cant enter more than one card");
        }

        public void InsertPin(int pinEntered)
        {
            if(pinEntered == 1234)
            {
                Console.WriteLine("Correct pin");
                atmMachine.correctPinEntered = true;
                atmMachine.setATMState(atmMachine.HasPin);
            } else
            {
                Console.WriteLine("Wrong pin");
                atmMachine.correctPinEntered = false;
                Console.WriteLine("Card Ejected");
                atmMachine.setATMState(atmMachine.NoCardState);
            }
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter pin first");
        }
    }
}
