using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnTVOn : ICommand
    {
        IElectronicDevice device;

        public TurnTVOn(IElectronicDevice newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.On();
        }
    }
}
