using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines a subtract operations.
    /// </summary>
    public class Subtract : AbstractOperation
    {
        override public string Symbol { get => "-"; }

        public Subtract(int firstArg, int secondArg) : base(firstArg, secondArg) { }

        override public int Execute()
        {
            return this.FirstArg - this.SecondArg;
        }
    }
}
