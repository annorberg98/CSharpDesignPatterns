using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class DeviceButton
    {
        ICommand theCommand;

        public DeviceButton(ICommand newCommand)
        {
            theCommand = newCommand;
        }

        public void Press()
        {
            theCommand.Execute();
        }
    }
}
