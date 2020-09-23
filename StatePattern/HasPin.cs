using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class HasPin : IATMState
    {
        ATMMachine atmMachine;

        public HasPin(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Card ejected");
            atmMachine.setATMState(atmMachine.NoCardState);
        }

        public void InsertCard()
        {
            Console.WriteLine("You cant enter more than one card");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("PIN already entered");
        }

        public void RequestCash(int cashToWithdraw)
        {
            if(cashToWithdraw > atmMachine.cashInMashine)
            {
                Console.WriteLine("Dont have that Cash");
                Console.WriteLine("Card ejected");
                atmMachine.setATMState(atmMachine.NoCardState);
            } else
            {

                Console.WriteLine("Cash to withdraw: " + cashToWithdraw);
                atmMachine.setChashInMachine(atmMachine.cashInMashine - cashToWithdraw);
                Console.WriteLine("Card ejected");
                atmMachine.setATMState(atmMachine.NoCardState);

                if(atmMachine.cashInMashine <= 0)
                {
                    atmMachine.setATMState(atmMachine.NoCashState);
                }

            }
        }
    }
}
