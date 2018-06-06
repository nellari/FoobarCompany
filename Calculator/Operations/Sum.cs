using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines a sum operation.
    /// </summary>
    public class Sum : AbstractOperation
    {
        override public string Symbol { get => "+"; }

        public Sum(int firstArg, int secondArg) : base(firstArg, secondArg) { }

        override public int Execute()
        {
            return this.FirstArg + this.SecondArg;
        }
    }
}
