using System;
using System.Collections.Generic;
using System.Text;

namespace PipeAndFilter
{
    /// <summary>  
    /// Pipeline that sends message to the destination by performing operations  
    /// on the incoming message  
    /// </summary>  
    public class SendPipeline : Pipelinebase<IMessage>
    {
        /// <summary>  
        /// Constructor for the class where the operations are registered  
        /// for the messages  
        /// </summary>  
        /// <param name="setPriority">The Set Priority parameter</param>  
        /// <param name="encryptMessage">The Encrypt Message parameter</param>  
        public SendPipeline(bool setPriority, bool encryptMessage)
        {
            if (setPriority)
            {
                Register(new MessagePriority());
            }

            if (encryptMessage)
            {
                Register(new EncryptMessage());
            }
        }
    }
}
