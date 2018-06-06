using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operations;

namespace Calculator
{
    public abstract class AbstractCalc : ICalc
    {
        private IOperationRegistry operationRegistry;

        protected AbstractCalc(IOperationRegistry operationRegistry)
        {
            this.operationRegistry = operationRegistry;
        }

        public IOperationRegistry OperationRegistry { get => operationRegistry; set => operationRegistry = value; }

        public abstract int Compute();
    }
}
