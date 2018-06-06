using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines an operation registry. 
    /// </summary>
    public interface IOperationRegistry
    {
        string[] GetAllSymbols { get; }
        IOperation CreateOperation(string symbol, int firstArg, int secondArg);
    }
}
