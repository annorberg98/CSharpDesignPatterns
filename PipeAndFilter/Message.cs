using System;
using System.Collections.Generic;
using System.Text;

namespace PipeAndFilter
{
    /// <summary>  
    /// Message class  
    /// </summary>  
    public class Message : IMessage
    {
        /// <summary>  
        /// boolean variables  
        /// </summary>  
        private string messageId;
        private string body;
        private string header;
        private string subject;

        /// <summary>  
        /// Properties to be set  
        /// </summary>  
        public int Priority { get; set; }


        public bool IsEncrypted { get; set; }

        /// <summary>  
        /// Property that returns MessageId  
        /// </summary>  
        public string MessageId
        {
            get { return messageId; }
        }

        /// <summary>  
        /// Property that returns body of the message  
        /// </summary>  
        public string Body
        {
            get { return body; }
        }

        /// <summary>  
        /// Property that returns the header of the message  
        /// </summary>  
        public string Header
        {
            get { return header; }
        }

        /// <summary>  
        /// Property that returns subject of the message  
        /// </summary>  
        public string Subject
        {
            get { return subject; }
        }

        /// <summary>  
        /// Constructor for the class Message  
        /// </summary>  
        /// <param name="messageId">The MessageId</param>  
        /// <param name="body">The Body</param>  
        /// <param name="header">The Header</param>  
        /// <param name="subject">The Subject</param>  
        public Message(string messageId, string body, string header, string subject)
        {
            this.messageId = messageId;
            this.body = body;
            this.header = header;
            this.subject = subject;
        }

        /// <summary>  
        /// Informs if the message is encrypted  
        /// </summary>  
        /// <returns>The value true/false</returns>  
        public bool IsMessageEncrypted()
        {
            return IsEncrypted;
        }

        /// <summary>  
        /// Informs if the message priority set  
        /// </summary>  
        /// <returns>The value true/falses</returns>  
        public bool IsMessagePrioritySet()
        {
            return (Priority != 0);
        }




    }
}
