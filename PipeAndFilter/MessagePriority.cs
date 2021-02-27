using System;
using System.Collections.Generic;
using System.Text;

namespace PipeAndFilter
{
    /// <summary>  
    /// Sets Message priority to the incoming message  
    /// </summary>  
    class MessagePriority : IOperation<IMessage>
    {
        /// <summary>  
        /// Executes the operations  
        /// </summary>  
        /// <param name="input">The input message</param>  
        /// <returns>Message with the priority set</returns>
        public IMessage Execute(IMessage input)
        {
            input.Priority = 1;
            return input;
        }
    }
}
