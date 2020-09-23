using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pinEntered);
        void RequestCash(int cashToWithdraw);
    }
}
