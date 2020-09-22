using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TVRemote
    {
        public static IElectronicDevice getDevice()
        {
            return new Television();
        }
    }
}
