using System;
using System.Collections.Generic;
using System.Text;

namespace PipeAndFilter
{
    /// <summary>  
    /// Encrypts the message  
    /// </summary>  
    class EncryptMessage : IOperation<IMessage>
    {
        /// <summary>  
        /// Executes the operation on the message  
        /// </summary>  
        /// <param name="input">The Input Message</param>  
        /// <returns>Type of IMessage</returns> 
        public IMessage Execute(IMessage input)
        {
            return Encrypt(input);
        }

        /// <summary>  
        /// Encrypts the message  
        /// </summary>  
        /// <param name="input">The Input Message</param>  
        /// <returns>Type of IMessage</returns>  
        private IMessage Encrypt(IMessage input)
        {
            input.IsEncrypted = true;
            //Encryption code  
            return input;
        }
    }
}
