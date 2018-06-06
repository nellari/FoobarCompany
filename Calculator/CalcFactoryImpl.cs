using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Create File or Interactive calculator.
    /// </summary>
    class CalcFactoryImpl : ICalcFactory
    {
        public const string Interactive = "Interactive";
        /// <summary>
        /// Returns the interactive calculator if <code>type</code> is 'Interactive' otherwise the file calculator.
        /// In thsi case te <code>type</code> value is interpreted as input file name.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>The interactive or file calculator</returns>
        public ICalc GetCalculator(string type)
        {
            if (Interactive.Equals(type))
                return new InteractiveCalc(new OperationRegistryImpl());
            else
                return new FileCalc(type, new OperationRegistryImpl());
        }
    }
}
