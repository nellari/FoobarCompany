using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Defines a calculator type
    /// </summary>
    interface ICalc
    {
        IOperationRegistry OperationRegistry { get; set; }
        int Compute();
    }
}
