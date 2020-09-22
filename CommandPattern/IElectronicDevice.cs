using System;

namespace CommandPattern
{
    public interface IElectronicDevice
    {
        public void On();
        public void Off();
        public void VolumeUp();
        public void VolumeDown();
    }
}
