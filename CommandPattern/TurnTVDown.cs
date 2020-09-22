using System;
using System.Collections.Generic;
using System.Text;
namespace CommandPattern
{
    public class TurnTVDown : ICommand
    {
        IElectronicDevice device;

        public TurnTVDown(IElectronicDevice newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.VolumeDown();
        }
    }
}