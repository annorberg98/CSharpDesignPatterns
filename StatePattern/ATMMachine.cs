using System;

namespace StatePattern
{
    public class ATMMachine
    {
        IATMState hasCard;
        IATMState noCard;
        IATMState hasCorrectPin;
        IATMState atmOutOfMoney;

        IATMState atmState;

        public int cashInMashine = 2000;
        public bool correctPinEntered = false;

        public ATMMachine()
        {
            hasCard = new HasCard(this);
            noCard = new HasCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);

            atmState = noCard;

            if(cashInMashine < 0)
            {
                atmState = atmOutOfMoney;
            }
        }

        public void setATMState(IATMState newATMState)
        {
            atmState = newATMState;
        }

        public void setChashInMachine(int newCash)
        {
            cashInMashine = newCash;
        }

        public void insertCard()
        {
            atmState.InsertCard();
        }

        public void ejectCard()
        {
            atmState.EjectCard();
        }

        public void requestCash(int cashToWithdraw)
        {
            atmState.RequestCash(cashToWithdraw);
        }

        public void insertPin(int pinEntered)
        {
            atmState.InsertPin(pinEntered);
        }

        public IATMState YesCardState => hasCard;

        public IATMState NoCardState => hasCard;

        public IATMState HasPin => hasCorrectPin;

        public IATMState NoCashState => atmOutOfMoney;

    }
}
