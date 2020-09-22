using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Television : IElectronicDevice
    {
        private int volume = 0;

        public void Off()
        {
            Console.WriteLine("TV is OFF");
        }

        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void VolumeDown()
        {
            volume--;
            Console.WriteLine("TV Volume is at " + volume);
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine("TV Volume is at " + volume);
        }
    }
}
