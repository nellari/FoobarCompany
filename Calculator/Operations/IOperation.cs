using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines an operation for a binary operators and relative int arguments.
    /// </summary>
    public interface IOperation
    {
        string Symbol { get; }

        int FirstArg { get; set; }

        int SecondArg { get; set; }

        int Execute();
    }
}
