using System;
using System.Collections.Generic;
using System.Text;
namespace CommandPattern
{
    public class TurnTVOff : ICommand
    {
        IElectronicDevice device;

        public TurnTVOff(IElectronicDevice newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.Off();
        }
    }
}