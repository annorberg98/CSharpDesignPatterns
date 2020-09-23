using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class NoCash : IATMState
    {
        ATMMachine atmMachine;
        public NoCash(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("We have no money. You didnt enter a card");
        }

        public void InsertCard()
        {
            Console.WriteLine("We have no money");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We have no money");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("We have no money");
        }
    }
}
