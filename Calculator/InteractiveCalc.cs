using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operations;

namespace Calculator
{
    /// <summary>
    /// Defines an interactive calculator.
    /// </summary>
    public class InteractiveCalc : AbstractCalc
    {
        public InteractiveCalc(IOperationRegistry registry) : base(registry) { }

        /// <summary>
        /// Gets operation arguments from the console.
        /// </summary>
        /// <returns>The list of arguments.</returns>
        public virtual string[] GetArguments()
        {
            string[] args = new string[3];
            Console.WriteLine("First argument: ");
            args[0] = Console.ReadLine();
            Console.WriteLine("Second Argument: ");
            args[1] = Console.ReadLine();
            Console.WriteLine("Operation (" + String.Join(" ", OperationRegistry.GetAllSymbols) + "): ");
            args[2] = Console.ReadLine();
            return args;
        }

        public override int Compute()
        {
            string[] args = this.GetArguments();
            return this.OperationRegistry.CreateOperation(args[2], int.Parse(args[0].Trim()), int.Parse(args[1].Trim())).Execute();
        }
    }
}
