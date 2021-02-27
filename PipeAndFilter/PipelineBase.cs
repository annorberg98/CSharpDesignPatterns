using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipeAndFilter
{
    /// <summary>  
    /// Base class for the pipeline classes  
    /// </summary>  
    /// <typeparam name="T">Type supported by the Pipeline base</typeparam>  
    public abstract class Pipelinebase<T>
    {
        private readonly List<IOperation<T>> operations = new List<IOperation<T>>();

        /// <summary>  
        /// Registers the operation  
        /// </summary>  
        /// <param name="operation">The operation</param>  
        /// <returns>The instance of the class</returns>  
        public Pipelinebase<T> Register(IOperation<T> operation)
        {
            this.operations.Add(operation);
            return this;
        }

        /// <summary>  
        /// Perform the operation  
        /// </summary>  
        /// <param name="input">The input message</param>  
        /// <returns>The instance of the class</returns>  
        public T PerformOperation(T input)
        {
            return this.operations.Aggregate(input, (current, operation) => operation.Execute(current));
        }
    }
}
