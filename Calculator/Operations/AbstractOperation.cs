using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines an abstract operation for a binary operators and relative int arguments.
    /// </summary>
    abstract public class AbstractOperation : IOperation
    {
        public int FirstArg { get; set; }
        public int SecondArg { get; set; }
        public abstract string Symbol { get; }

        public AbstractOperation(int firstArg, int secondArg)
        {
            FirstArg = firstArg;
            SecondArg = secondArg;
        }

        public abstract int Execute();
    }
}
