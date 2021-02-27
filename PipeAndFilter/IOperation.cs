using System;

namespace PipeAndFilter
{
    /// <summary>  
    /// Operation Interface  
    /// All operations must implement the interface  
    /// </summary>  
    /// <typeparam name="T">Data type supported in the operation</typeparam>   
    public interface IOperation<T>
    {
        /// <summary>  
        /// Executes the operation  
        /// </summary>  
        /// <param name="input">The Input Parameter</param>  
        /// <returns>Type defined for the operation</returns>
        T Execute(T input);
    }
}
