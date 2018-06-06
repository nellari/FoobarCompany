using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines a multiply operation.
    /// </summary>
    public class Multiply : AbstractOperation
    {
        override public string Symbol { get => "*"; }

        public Multiply(int firstArg, int secondArg) : base(firstArg, secondArg) { }

        override public int Execute()
        {
            return this.FirstArg * this.SecondArg;
        }
    }
}
