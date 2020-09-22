using System;
using System.Collections.Generic;
using System.Text;
namespace CommandPattern
{
    public class TurnTVUp : ICommand
    {
        IElectronicDevice device;

        public TurnTVUp(IElectronicDevice newDevice)
        {
            device = newDevice;
        }
        public void Execute()
        {
            device.VolumeUp();
        }
    }
}