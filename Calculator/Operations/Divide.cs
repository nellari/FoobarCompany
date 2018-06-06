using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// Defines the divide operation.
    /// </summary>
    public class Divide : AbstractOperation
    {
        override public string Symbol { get => "/"; }

        public Divide(int firstArg, int secondArg) : base(firstArg, secondArg) { }

        override public int Execute()
        {
            if (this.SecondArg == 0)
                throw new DivideByZeroException();
            return this.FirstArg / this.SecondArg;
        }
    }
}
