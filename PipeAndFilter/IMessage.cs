using System;
using System.Collections.Generic;
using System.Text;

namespace PipeAndFilter
{
    /// <summary>  
    /// Message Interface  
    /// </summary>  
    public interface IMessage
    {
        /// <summary>  
        /// Priority of the message  
        /// </summary>  
        int Priority { get; set; }

        /// <summary>  
        /// Field that needs to be implemented by the  
        /// implementing the classes  
        /// </summary>  
        bool IsEncrypted { get; set; }

        /// <summary>  
        /// Tells if the message is encrypted  
        /// </summary>  
        /// <returns></returns>  
        bool IsMessageEncrypted();

        /// <summary>  
        /// Tells if the priority is set  
        /// </summary>  
        /// <returns></returns>  
        bool IsMessagePrioritySet();

        /// <summary>  
        /// Message Id of the message  
        /// </summary>  
        string MessageId { get; }

        /// <summary>  
        /// Body of the message  
        /// </summary>  
        string Body { get; }

        /// <summary>  
        /// Header of the message  
        /// </summary>  
        string Header { get; }

        /// <summary>  
        /// Subject of the message  
        /// </summary>  
        string Subject { get; }
    }
}
