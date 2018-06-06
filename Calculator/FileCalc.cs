using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operations;

namespace Calculator
{
    /// <summary>
    /// Reads from a file the arguments and the operator.
    /// </summary>
    public class FileCalc : AbstractCalc
    {
        private string filePath;
        public FileCalc(string filePath, IOperationRegistry registry) : base(registry) {
            this.filePath = filePath;
        }

        /// <summary>
        /// Performs the calculation if all parameters are provided.
        /// </summary>
        /// <returns>The result of the operation.</returns>
        public override int Compute()
        {
            var strings = File.ReadAllText(filePath).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (strings == null || strings.Length < 1)
                throw new ArgumentException();
            return OperationRegistry.CreateOperation((strings.Length > 2) ? strings[2] : string.Empty, int.Parse(strings[0].Trim()), int.Parse(strings[1].Trim())).Execute();
        }
    }
}
